using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{ public GameObject EnemyBullet;
    public GameObject EnemyFlash;
    public Transform EnemyGunpoint1;
    public Transform EnemyGunpoint2;
    public float EnemyBulletSponTime = 0.5f;
    public float speed = 0.4f;
    // Start is called before the first frame update
    void Start()
    {
        EnemyFlash.SetActive(false);
        StartCoroutine(EnemyShooting());
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime) ;
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
            yield return new WaitForSeconds(EnemyBulletSponTime);
            EnemyFire();
            EnemyFlash.SetActive(true);
            yield return new WaitForSeconds(EnemyBulletSponTime);
            EnemyFlash.SetActive(false);


        }

    }
}
