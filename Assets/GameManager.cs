using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Zommbie;
    public float ZombieQty;

    // Start is called before the first frame update
    void Start()
    {
        Random.Range(1, ZombieQty);
    }

    // Update is called once per frame
    void Update()
    {

           
    }
}
