using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    float speed = 10f;

    // Start is called before the first frame update

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
        float newXpos = transform.position.x + HorizontalInput;
        float newYpos = transform.position.y + VerticalInput;
        transform.position = new Vector2(newXpos, newYpos);

        // for vrtical movement:
        //float VerticalInput = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        //body.velocity = new Vector2(body.velocity.y, VerticalInput);
    }
}