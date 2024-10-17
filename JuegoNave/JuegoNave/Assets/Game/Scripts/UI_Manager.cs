using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_Manager : MonoBehaviour
{

    public void playgame()
    {
        SceneManager.LoadScene("");
        
    }

    public void abandonar()
    {
    Application.Quit();
    }

}


