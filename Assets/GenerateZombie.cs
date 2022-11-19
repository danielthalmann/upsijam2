using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class GenerateZombie : MonoBehaviour
{
    public GameObject zombie;

    public float y_height;
    public float rayon;
    public float pauseTime;
    // Start is called before the first frame update
    private float nextTime;
    private int waveOfZombies;

    void Start()
    {
        nextTime = 0;
        waveOfZombies = 0;
    }

    // Update is called once per frame
    void Update()
    {

        if (Time.time > nextTime)
        {
            GenerateZ(waveOfZombies);
            waveOfZombies++;
            nextTime = Time.time + pauseTime;
        }
        
    }

    private void GenerateZ(int i)
    {
        
        while(i > 0)
        {
            Vector3 positionZombie = FindRandomPosition();
            Instantiate(zombie, positionZombie, Quaternion.identity);
            i--;
        }
        
    }

    private Vector3 FindRandomPosition()
    {
        float val = Random.Range(0, 360);
        float x_height = Mathf.Cos(val) * rayon;
        float z_height = Mathf.Sin(val) * rayon;
        return new Vector3(x_height, y_height, z_height);
    }
}
