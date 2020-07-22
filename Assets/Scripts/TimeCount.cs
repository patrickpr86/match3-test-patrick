using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class TimeCount : MonoBehaviour { 

    public Text timeText;
    public float time = 0;
    public float amountTime = 120;

    public bool finalTime ;



    // Start is called before the first frame update
    void Start()    {
        time = amountTime;
    }

    // Update is called once per frame
    void Update()    {
       timer();
    }

    void timer(){
        if(!finalTime ){

            time -= Time.deltaTime;
            print(time);
            TimeSpan timeSpan = TimeSpan.FromSeconds(time);
            timeText.text = string.Format("{1:D2}:{2:D2}", timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds);
            if(time <= 0){
                finalTime = true;
                //chamar função para proximo level
            }
        }

        

    }


}
