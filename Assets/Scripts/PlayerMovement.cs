using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D body;
   private float speed=3000f;
    
    // Start is called before the first frame update

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        
       
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }
    private void Movement()
    {  // For Horizontal & Vertical Movement:
        float HorizontalInput = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float VerticalInput = Input.GetAxis("Vertical") * speed * Time.deltaTime; // This is for vertical movement:
        body.velocity = new Vector2(HorizontalInput, VerticalInput);

        // for vrtical movement:
        //float VerticalInput = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        //body.velocity = new Vector2(body.velocity.y, VerticalInput);
    }
}
