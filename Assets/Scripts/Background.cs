using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{  // Rendrer is used for calling meshrendrer:
    public Renderer meshRend;
    public float speed;

    // Update is called once per frame
    void Update()
    {
        // scrolling of background

        Vector2 offset = meshRend.material.mainTextureOffset;
        offset = offset + new Vector2(0, speed * Time.deltaTime);
        meshRend.material.mainTextureOffset = offset;
        //meshRend.material.mainTextureOffset += new Vector2(0f, speed * Time.deltaTime);
        
    }
}
