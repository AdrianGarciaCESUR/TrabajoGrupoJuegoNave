using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Offset : MonoBehaviour
{
    [Header("Velocidad")]
    public float capa1_scroll = 0.3f;
    public float capa2_scroll = 0.25f;
    public float capa3_scroll = 0.2f;
    public float capa4_scroll = 0.15f;

    [Header("Materiales")]
    public Material capa1;
    public Material capa2;
    public Material capa3;
    public Material capa4;

    private void Start()
    {
        capa1.mainTextureOffset = Vector2.zero;
        capa2.mainTextureOffset = Vector2.zero;
        capa3.mainTextureOffset = Vector2.zero;
        capa4.mainTextureOffset = Vector2.zero;
    }

    void Update()
    {
        capa1.mainTextureOffset += new Vector2(0f, capa1_scroll * Time.deltaTime);
        capa2.mainTextureOffset += new Vector2(0f, capa2_scroll * Time.deltaTime);
        capa3.mainTextureOffset += new Vector2(0f, capa3_scroll * Time.deltaTime);
        capa4.mainTextureOffset += new Vector2(0f, capa4_scroll * Time.deltaTime);
    }
}
