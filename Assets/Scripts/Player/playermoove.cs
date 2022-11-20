using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermoove : MonoBehaviour
{
    public float speed = 50;
    public float positionY = 0.51f;
    public GameObject holeToSpawn;
    public Animator anim;
    public GameObject Canvas2;
    public SceneController SC;
    public float shoot_timer = 0.3f;



    private Rigidbody body;
    private float t = 0;
    private float positionX;
    private float positionZ;
    private Vector3 hauter;

    private void OnTriggerEnter(Collider collision)
    {
        Debug.Log("trigger with " + collision.gameObject.transform.name);
        if (collision.tag == "zombie")
        {
            Canvas2.SetActive(true);
            SC.LoadScene("Menu");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
        //positionY = transform.position.y;

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
        hauter = new Vector3(positionX, positionY, positionZ);
    }

    private void Dig()
    {
        Instantiate(holeToSpawn, hauter, Quaternion.identity);
    }
}
