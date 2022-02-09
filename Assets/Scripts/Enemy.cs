using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{ public GameObject EnemyBullet;
    public Transform EnemyGunpoint1;
    public Transform EnemyGunpoint2;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EnemyShooting());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void EnemyFire()
    {
        Instantiate(EnemyBullet, EnemyGunpoint1.position, Quaternion.identity);
        Instantiate(EnemyBullet, EnemyGunpoint2.position, Quaternion.identity);
    }
    IEnumerator EnemyShooting()
    {
       
        while (true)
        {
            yield return new WaitForSeconds(0.5f);
            EnemyFire();

        }

    }
}
