using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Timer : MonoBehaviour 
{
    public Text timer;
    float countDown = 0.0f;
    int minute = 0;
    string second;
    int i = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        countDown += Time.deltaTime % 60;
        second = ((int)countDown).ToString();

        if ((int)countDown > 59)
        {
            minute++;
            countDown = 0;
        }
        else if ((int)countDown < 10)
        {
            second = "0" + second;
        }

        if ((int)countDown % 10 == 0)
        {
            i++;
            if (i == 1)
            {
                Helio.helio -= 5;
            }
        }
        else
        {
            i = 0;
        }

        timer.text = $"{minute}:{second}";
        
    }
}
