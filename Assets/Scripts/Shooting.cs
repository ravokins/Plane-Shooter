using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject playerBullet;
    public Transform Spwonpoint1;
    public Transform Spwonpoint2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        FireInstanciate();
        
       
    }
    //Spowning bullet using Instantiate:
    void FireInstanciate()
    {

        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(playerBullet, Spwonpoint1.position, Quaternion.identity);// Uses:- Identity means there is no rotation, playerbullet is a gameobject,transform.position is used as a position.
            Instantiate(playerBullet, Spwonpoint2.position, Quaternion.identity);
        }

    }
}
