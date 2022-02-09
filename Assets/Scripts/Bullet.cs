using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float speed =10f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {  // This is used for giving bullet movment:
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }
}