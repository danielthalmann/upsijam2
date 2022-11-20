using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CounterUpdate : MonoBehaviour
{

    public TextMeshProUGUI textCounter;
    int lastCounter = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (lastCounter != GameStatus.zombiesCounter)
        {
            lastCounter = GameStatus.zombiesCounter;
            textCounter.text = lastCounter.ToString();
        }
        
    }
}
