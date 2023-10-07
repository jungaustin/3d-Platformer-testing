using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 500f;
    public float sidewaysForce = 500f;
    public float jumpForce = 1000f;
    private bool jump;
    
    // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    //Update is called once per frame
    void Update(){
        if(Input.GetKey("space")) {
            jump = true;
        }
        else {
            jump = false;
        }
    }
    //We are using FixedUpdate instead of Update becayuse Unity likes FixedUpdate more when we are working with Physics
    void FixedUpdate()
    {
        //add a forward force
        //rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        
        if(Input.GetKey("d")) {
            rb.AddForce(sidewaysForce * Time.deltaTime,0,0);
        }
        if(Input.GetKey("a")) {
            rb.AddForce(-sidewaysForce * Time.deltaTime,0,0);
        }
        if(Input.GetKey("w")) {
            rb.AddForce(0,0,forwardForce * Time.deltaTime);
        }
        if(Input.GetKey("s")) {
            rb.AddForce(0,0,-forwardForce * Time.deltaTime);
        }
        if(jump) {
            rb.AddForce(0,jumpForce * Time.deltaTime,0);
        }

    }
}
