using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieMoove : MonoBehaviour
{
    private Rigidbody zbody;
    private Vector3 target;
    public float moveSpeed;
    public float moveVelocity;
    private float targetDistance;
    private bool grounded = true;

    private void OnTriggerEnter(Collider collision)

    {
        if (collision.tag == "Player")
            Destroy(collision.gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "ground")
            grounded = true;
    }
    // Start is called before the first frame update
    void Start()
    {
        zbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    public void Move()
    {
        moveVelocity = 1f;
        target = new Vector3(0.0f, 1.0f, 0.0f);
        transform.position = Vector3.MoveTowards(transform.position, target, moveVelocity * Time.deltaTime);
    }
}

