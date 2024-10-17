using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Temporizador : MonoBehaviour
{
    [SerializeField] TMP_Text timerText;

    public GameObject game_manager;
    public int rate = 3;


    float elapsedTime;

    int minutes;
    int seconds;

    bool is_timer_running = false;
    bool is_just_entered = false;

    void Update()
    {
        if (is_timer_running)
        {
            elapsedTime += Time.deltaTime;
            _Math_Time(elapsedTime);

            timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }

        if (seconds % rate == 0 && seconds != 0 && !is_just_entered)
        {
            is_just_entered = true;
            game_manager.GetComponent<GameManager>().IncreaseMeteoritoSpawnFrequency();
        }
        else if (seconds % rate != 0)
        {
            is_just_entered = false;
        }
        
    }

    private void _Math_Time(float f_elapsedTime)
    {
        minutes = Mathf.FloorToInt(f_elapsedTime / 60f);
        seconds = Mathf.FloorToInt(f_elapsedTime % 60f);
    }

    public void StopTimer()
    {
        is_timer_running = false;
    }

    public void StarTimer(int f_seconds = 0)
    {
        elapsedTime = f_seconds;
        _Math_Time(elapsedTime);

        is_timer_running = true;
    }


    

}
