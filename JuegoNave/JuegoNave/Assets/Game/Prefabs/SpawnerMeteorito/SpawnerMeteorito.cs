using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SpawnerMeteorito : MonoBehaviour
{

    public float startTime = 1f;
    public float delay = 1f;

    public bool is_enable = true;

    public Transform Prefab_Meteorito;
    private Bounds spawnBounds;

    private void Start()
    {
        spawnBounds = GetComponent<BoxCollider2D>().bounds;
        if (is_enable)
        {
            InvokeRepeating("_spawnMeteorito", startTime, delay);
        }
    }


    void _spawnMeteorito()
    {
        Vector2 instance_spawnPos = Vector2.zero;

        instance_spawnPos.y = spawnBounds.center.y;
        instance_spawnPos.x = Random.Range(spawnBounds.min.x, spawnBounds.max.x);

        Transform instance;
        instance = Instantiate(Prefab_Meteorito);
        instance.position = instance_spawnPos;
    }
}
