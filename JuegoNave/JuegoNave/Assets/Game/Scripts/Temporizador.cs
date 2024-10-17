using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Temporizador : MonoBehaviour
{
    //[SerializeField] TMP_Text timerText;
    public GameObject textObject;
    float elapsedTime;

    void Update()
    {
        elapsedTime += Time.deltaTime;
        int minutes = Mathf.FloorToInt(elapsedTime/60f);
        int seconds = Mathf.FloorToInt(elapsedTime%60f);

        textObject.GetComponent<TMP_Text>().text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
