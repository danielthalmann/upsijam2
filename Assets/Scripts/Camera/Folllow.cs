using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Folllow : MonoBehaviour
{
    public Camera cam;

    public Vector3 offset;
    public float nutelaspeed = 0.125f;
    public Transform target;


    // Update is called once per frame
    void Update()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 SmoothPosition = Vector3.Lerp(cam.transform.position, desiredPosition, nutelaspeed);
        cam.transform.position = SmoothPosition;
    }
}
