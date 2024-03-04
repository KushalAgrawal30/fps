using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float moveSpeed = 10f;
    [SerializeField] float jumpQt = 1f;
    bool inAir = false; //to check if the playe is in air

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Jump();
        Movement();
    }

    void Movement()
    {
        if (Input.GetKey(KeyCode.W)) 
        {
            transform.position += Vector3.forward * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.back * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * moveSpeed * Time.deltaTime;
        }
    }

    void OnCollisionEnter(Collision collision) 
    {
        inAir = true;
    }

    void Jump()
    {
        if(inAir) //if player is in air it will not furthur jump in the air 
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.velocity = Vector3.up * jumpQt;
                inAir = false; //when player jumps it makes the inAir value false
            }
        }
       

    }
}
