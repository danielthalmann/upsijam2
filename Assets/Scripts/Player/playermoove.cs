using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermoove : MonoBehaviour
{
    public float speed = 50;
    private Rigidbody body;
    public float positionY;
    public float positionX;
    public float position3;
    public GameObject holeToSpawn;
    public Vector3 hauter;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
        positionY = transform.position.y;

    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 velocity = new Vector3(horizontalInput, positionY, verticalInput);
        velocity = Quaternion.AngleAxis(-45, Vector3.up) * velocity;

        positionX = transform.position.x;
        position3 = transform.position.z;
        body.velocity = velocity * speed;
        //body.velocity = transform.TransformDirection(body.velocity);
        // body.velocity *= speed;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Dig();
        }
        hauter = new Vector3(positionX, 0.51f, position3);
    }

    private void Dig()
    {
        Instantiate(holeToSpawn, hauter, Quaternion.identity);
    }
}   