using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public HelthBar helthBar;
    public GameObject EnemyBullet;
    public GameObject EnemyFlash;
    public GameObject EnemyDeadExplosionPrefab;
    public Transform EnemyGunpoint1;
    public Transform EnemyGunpoint2;
    public float EnemyBulletSponTime = 0.5f;
    public float speed = 0.4f;
    public float Health = 10f;
    float Barsize = 1f;
    float Damage = 0;


    // Start is called before the first frame update
    void Start()
    {
        EnemyFlash.SetActive(false);
        StartCoroutine(EnemyShooting());

        Damage = Barsize / Health;
    }

    // Update is called once per frame
    void Update()
    { // this is used for making enemy move downward.
        transform.Translate(Vector2.down * speed * Time.deltaTime);
       //transform.Translate(Vector2(0,0))

    }
    
    void EnemyFire()
    {  // thiss is used for spown bullet from enemy using Instantiate:
        Instantiate(EnemyBullet, EnemyGunpoint1.position, Quaternion.identity);
        Instantiate(EnemyBullet, EnemyGunpoint2.position, Quaternion.identity);
    }
    // IEnumerator is a function which call any function directly: in this case we are ussing this for spoWning enemyfire withouth pressing any button.
    IEnumerator EnemyShooting()
    {
       
       
        while (true)
        { // this is used to say enmy fire have to wait before shooting:
            yield return new WaitForSeconds(EnemyBulletSponTime);
            EnemyFire();
            // this enemyflas.setactive is ued foe showing flash while fire.
            EnemyFlash.SetActive(true);
            // this is used bczz enemy flah wait for a moment and then again showing flash with enemy firing
            yield return new WaitForSeconds(EnemyBulletSponTime);
            EnemyFlash.SetActive(false);


        }

    }
     void DamageHealthBar()
    {
        if (Health>0)
        {
            Health -= 1;
            Barsize = Barsize - Damage;
            helthBar.Setsize(Barsize);
        }
    }
    // Destroying Enemy using Collision:
    private void OnTriggerEnter2D(Collider2D collision)
    { // to check if player bullet colide with enemy.
        
        if (collision.tag==("Player Bullet"))
        {
            DamageHealthBar();
            Destroy(collision.gameObject);
            if (Health <= 0)
            {
                Destroy(gameObject);
                // this is to spown Enemy Dead explosion and gameobject enemydradexplosion is used there for destroying explosion not explosion prefab:
                GameObject EnemyDeadExplosin = Instantiate(EnemyDeadExplosionPrefab, transform.position, Quaternion.identity);
                // this block is used for destroy explosion after few second:
                Destroy(EnemyDeadExplosin, 0.2f);
            }
           
        }
    }
}
