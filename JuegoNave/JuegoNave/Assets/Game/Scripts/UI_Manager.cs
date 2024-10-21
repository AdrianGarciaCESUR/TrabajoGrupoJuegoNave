using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_Manager : MonoBehaviour
{
    public GameObject menupausa;
    public bool esta_pausado = false;
    public bool is_mainmenu = false;

    public void playgame(string name)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(name);
        
    }

    public void abandonar()
    {
    Application.Quit();
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !is_mainmenu)
        {
           resumir();

        }
    }
    public void resumir()
    {
        esta_pausado = !esta_pausado;

        /*if(esta_pausado )
        {
            Time.timeScale = 0.0f;
        }
        else
        {
            Time.timeScale = 1.0f;
            menupausa.SetActive(false);
        }*/

        Time.timeScale = esta_pausado ? 0 : 1;
        menupausa.SetActive(esta_pausado);
    }

}


