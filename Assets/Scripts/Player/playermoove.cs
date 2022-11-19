using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermoove : MonoBehaviour
{
    public float speed = 50;
    public float positionY;
    public float positionX;
    public float positionZ;
    public GameObject holeToSpawn;
    public Vector3 hauter;
    public Animator anim;



    private Rigidbody body;
    private float shoot_timer = 0.5f;
    private float t = 0;
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
        if (horizontalInput != 0f || verticalInput != 0f)
            anim.SetBool("walk", true);
        else
            anim.SetBool("walk", false);


        Vector3 velocity = new Vector3(horizontalInput, positionY, verticalInput);
        velocity = Quaternion.AngleAxis(-45, Vector3.up) * velocity;

        positionX = transform.position.x;
        positionZ = transform.position.z;
        body.velocity = velocity * speed;
        //body.velocity = transform.TransformDirection(body.velocity);
        // body.velocity *= speed;
        t += Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space) && t > shoot_timer)
        {
            t = 0;
            Dig();
        }
        hauter = new Vector3(positionX, 0.51f, positionZ);
    }

    private void Dig()
    {
        Instantiate(holeToSpawn, hauter, Quaternion.identity);
    }
}
