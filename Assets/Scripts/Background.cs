using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public Renderer meshRend;
    public float speed;

    // Update is called once per frame
    void Update()
    {
        Vector2 offset = meshRend.material.mainTextureOffset;
        offset = offset + new Vector2(0, speed * Time.deltaTime);
        meshRend.material.mainTextureOffset = offset;
        //meshRend.material.mainTextureOffset += new Vector2(0f, speed * Time.deltaTime);
        
    }
}
