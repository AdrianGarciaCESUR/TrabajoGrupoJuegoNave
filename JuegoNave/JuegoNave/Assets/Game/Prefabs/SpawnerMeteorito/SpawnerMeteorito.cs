using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SpawnerMeteorito : MonoBehaviour
{

    [Header("Velocidades")]
    public float startTime = 1f;
    public float delay_max = 1f;
    float delay = 1f;

    float increase_speed = 0.85f;

    [Header("Bools")]
    public bool is_enable = true;

    public Transform Prefab_Meteorito;
    private Bounds spawnBounds;

    private void Start()
    {
        delay = delay_max;
        spawnBounds = GetComponent<BoxCollider2D>().bounds;
        InvokeRepeating("_spawnMeteorito", startTime, delay);

    }


    private void Update()
    {
        if (!is_enable)
        {
            CancelInvoke("_spawnMeteorito");
        }
    }

    public void IncreaseDelay()
    {
        delay = Mathf.Clamp(delay * increase_speed, 0.1f, delay_max);
        CancelInvoke("_spawnMeteorito");
        InvokeRepeating("_spawnMeteorito", startTime, delay);
        Debug.Log(delay.ToString());
    }

    void _spawnMeteorito()
    {
        Vector2 instance_spawnPos;

        instance_spawnPos.y = spawnBounds.center.y;
        instance_spawnPos.x = Random.Range(spawnBounds.min.x, spawnBounds.max.x);

        Transform instance;
        instance = Instantiate(Prefab_Meteorito);
        instance.position = instance_spawnPos;
    }
}
