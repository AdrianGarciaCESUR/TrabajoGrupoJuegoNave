using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Temporizador : MonoBehaviour
{
    [SerializeField] TMP_Text timerText;
    
    float elapsedTime;

    int minutes;
    int seconds;
    float miliseconds;

    bool is_timer_running = false;

    void Update()
    {
        if (is_timer_running)
        {
            elapsedTime += Time.deltaTime;
            _Math_Time(elapsedTime);

            timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
        
    }

    private void _Math_Time(float f_elapsedTime)
    {
        minutes = Mathf.FloorToInt(f_elapsedTime / 60f);
        seconds = Mathf.FloorToInt(f_elapsedTime % 60f);
        miliseconds = f_elapsedTime % 60f - seconds;
    }

    public void StopTimer()
    {
        is_timer_running = false;
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    public void StarTimer(int f_seconds = 0)
    {
        elapsedTime = f_seconds;
        _Math_Time(elapsedTime);

        is_timer_running = true;
    }


    

}
