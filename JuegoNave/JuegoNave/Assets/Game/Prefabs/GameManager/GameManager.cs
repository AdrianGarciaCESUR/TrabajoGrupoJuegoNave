using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    public GameObject spawner_meteorito;
    public GameObject temporizador;

    public GameObject menu_death;
    //public GameObject menu_pause;


    private void Start()
    {
        menu_death.gameObject.SetActive(false);
        temporizador.GetComponent<Temporizador>().StarTimer();
    }


    public void IncreaseMeteoritoSpawnFrequency()
    {
        spawner_meteorito.GetComponent<SpawnerMeteorito>().IncreaseDelay();
    }

    public void OnPlayerDeath()
    {
        temporizador.GetComponent<Temporizador>().StopTimer();
        spawner_meteorito.GetComponent<SpawnerMeteorito>().is_enable = false;
        menu_death.gameObject.SetActive(true);

    }

}
