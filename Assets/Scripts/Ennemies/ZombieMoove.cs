using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieMoove : MonoBehaviour
{
    private Rigidbody zbody;
    private Vector3 target;
    public float moveVelocity = 2.0f;
    private float targetDistance;
    Collider zombie;

    private void OnTriggerEnter(Collider collision)
    {
        Debug.Log("trigger with " + collision.gameObject.transform.name);
        if (collision.tag == "Player" || collision.tag == "trou")
        {
            zombie.isTrigger = false;
            Destroy(collision.gameObject);
        }
        zombie.isTrigger = true;

    }
    // Start is called before the first frame update
    void Start()
    {
        zombie = GetComponent<Collider>();
        zbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
    }
    public void Move()
    {
        target = new Vector3(0.0f, 1.0f, 0.0f);
        zbody.velocity = (target - transform.position).normalized * moveVelocity;
        //transform.position = Vector3.MoveTowards(transform.position, target, moveVelocity * Time.deltaTime);
    }
}

