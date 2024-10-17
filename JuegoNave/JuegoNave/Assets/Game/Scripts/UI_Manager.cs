using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_Manager : MonoBehaviour
{

    public void playgame(string name)
    {
        SceneManager.LoadScene(name);
        
    }

    public void abandonar()
    {
    Application.Quit();
    }

}


