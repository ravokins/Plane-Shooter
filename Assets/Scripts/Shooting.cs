using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject playerBullet;
    public Transform Spwonpoint1;
    public Transform Spwonpoint2;
    public GameObject PlayerFlash;

    // Start is called before the first frame update
    void Start()
    {
        PlayerFlash.SetActive(false);


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
            PlayerFlash.SetActive(true);
        }
        else if ( Input.GetButtonUp("Fire1"))
        {
            PlayerFlash.SetActive(false);
        }

    }
}
