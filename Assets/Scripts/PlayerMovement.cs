using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   
    float speed = 10f;
    float Padding = 0.8f;
    public PlayerHelth playerHelth;
    public GameObject Particalblastpref;
    public float Health= 20f;
    float Barsize = 1f;
    float Damage = 0;
    float min_X;
    float max_X;
    float min_Y;
    float max_Y;

    // Start is called before the first frame update
   
    void Start()
    {
        FindBoundaries();
        Damage = Barsize / Health;

    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        
    }
    void FindBoundaries()
    {  // adding clamping in x and y axis to make player stay in sceen:

        Camera gameCamera = Camera.main;
        min_X = gameCamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).x+Padding;
        max_X = gameCamera.ViewportToWorldPoint(new Vector3(1, 0, 0)).x-Padding;
        min_Y = gameCamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).y+Padding;
        max_Y = gameCamera.ViewportToWorldPoint(new Vector3(0, 1, 0)).y-Padding;
    }
    private void Movement()
    {  // For Horizontal & Vertical Movement:
        float HorizontalInput = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float VerticalInput = Input.GetAxis("Vertical") * speed * Time.deltaTime; // This is for vertical movement: 
        float newXpos = Mathf.Clamp( transform.position.x + HorizontalInput,min_X,max_X);       
        float newYpos =Mathf.Clamp( transform.position.y + VerticalInput,min_Y,max_Y);
        transform.position = new Vector2(newXpos, newYpos);

        // for vrtical movement:
        //float VerticalInput = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        //body.velocity = new Vector2(body.velocity.y, VerticalInput);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    { 
        if ( collision.gameObject.tag==("Enemy Bullet"))
        {
            playerHealthBar();
            Destroy(collision.gameObject);
            if (Health <= 0)
            {
                Destroy(gameObject);
                GameObject playerdeadeffect = Instantiate(Particalblastpref, transform.position, Quaternion.identity);
                Destroy(playerdeadeffect, 0.2f);
            }
            
        }
        
    }
    void playerHealthBar()
    {
        if(Health > 0)
        {
            Health -= 1;
            Barsize = Health - Damage;
            playerHelth.SetAmount(Barsize);
        }
    }
}