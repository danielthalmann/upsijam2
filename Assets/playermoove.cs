using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermoove : MonoBehaviour
{
    public float speed = 50;
    private Rigidbody body;
    private float position;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
        position = transform.position.y;

    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        body.velocity = new Vector3(horizontalInput, position, verticalInput);
        body.velocity = transform.TransformDirection(body.velocity);
        body.velocity *= speed;
    }
}   
