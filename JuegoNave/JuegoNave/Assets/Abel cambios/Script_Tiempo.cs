using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Script_Tiempo : MonoBehaviour
{
    [SerializeField] TMP_Text timerText;
    float elapsedTime;

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        int minutes=Mathf.FloorToInt(elapsedTime/60f);
        int seconds=Mathf.FloorToInt(elapsedTime%60f);

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
