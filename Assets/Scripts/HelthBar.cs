using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelthBar : MonoBehaviour
{
    public Transform Bar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Setsize(float size)
    {
        Bar.localScale = new Vector2(size, 1f);
    }
}
