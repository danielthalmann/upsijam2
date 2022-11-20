using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerController : MonoBehaviour
{
    public TextMeshProUGUI counterText;
    public int seconds, minutes;
    private float initTimer = 0f;
    // Start is called before the first frame update
    void Start()
    {
        seconds = 0;
        minutes = 0;
        initTimer = Time.time;


    }

    // Update is called once per frame
    void Update()
    {
        minutes = (int)((Time.time - initTimer) / 60f);
        seconds = (int)((Time.time - initTimer) % 60f);
        counterText.text = minutes.ToString("00") + ":" + seconds.ToString("00");
    }

}
