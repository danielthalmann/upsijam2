using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class GenerateZombie : MonoBehaviour
{
    public GameObject zombie;
    public Vector3 positionZombie;
    public float rayon;
    public float pauseTime;
    public float nextTime;
    public int waveOfZombies;
    // Start is called before the first frame update
    void Start()
    {
        rayon = 35;
        pauseTime = 5;
        nextTime = 0;
        waveOfZombies = 0;
    }

    // Update is called once per frame
    void Update()
    {

        if (Time.time > nextTime)
        {
            GenerateZ();
            waveOfZombies++;
            nextTime = Time.time + pauseTime;
        }
        
    }

    private void GenerateZ()
    {
        int i = waveOfZombies;
        while(i > 0)
        {
            positionZombie = FindRandomPosition();
            Instantiate(zombie, positionZombie, Quaternion.identity);
            i--;
        }
        
    }

    private Vector3 FindRandomPosition()
    {
        float val = Random.Range(0, 360);
        float x_heigt = Mathf.Cos(val) * rayon;
        float z_height = Mathf.Sin(val) * rayon;
        return new Vector3(x_heigt, 0.51f, z_height);
    }
}
