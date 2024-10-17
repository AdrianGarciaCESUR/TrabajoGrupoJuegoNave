using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    public GameObject spawner_meteorito;
    public GameObject temporizador;


    private void Start()
    {
        temporizador.GetComponent<Temporizador>().StarTimer();
    }

    public void OnPlayerDeath()
    {
        temporizador.GetComponent<Temporizador>().StopTimer();
        spawner_meteorito.GetComponent<SpawnerMeteorito>().is_enable = false;
    }

}
