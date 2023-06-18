using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    MeshRenderer meshRenderer;

    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        float x = 0.2f * Time.time;
        //Since we want to move in the X axis I wrote the variable and kept the Y axis 0
        meshRenderer.material.SetTextureOffset("_MainTex", new Vector2(x,0)); 
        
    }
}
