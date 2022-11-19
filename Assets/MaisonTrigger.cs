using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaisonTrigger : MonoBehaviour
{
    public GameObject Canvas;
    public SceneController SC;

    private void OnTriggerEnter(Collider collision)
    {
        Debug.Log("trigger with " + collision.gameObject.transform.name);
        if (collision.tag == "zombie")
        {
            Canvas.SetActive(true);
            SC.LoadScene("Menu");
        }
    }
        // Start is called before the first frame update
        void Start()
        {
        
        }

    // Update is called once per frame
        void Update()
        {

        }
}
