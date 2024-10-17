using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    public GameObject spawner_meteorito;

    public void OnPlayerDeath()
    {
        spawner_meteorito.GetComponent<SpawnerMeteorito>().is_enable = false;
    }

}
