using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScripts : MonoBehaviour
{
    public Renderer rend;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rend.material.mainTextureOffset += new Vector2(0f, speed * Time.deltaTime);
        
    }
}
