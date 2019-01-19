﻿using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;
    // Use this for initialization
    public float forwardForce = 500f;
    public float sidewaysForce = 100f;


	void Start ()
    {

        Debug.Log("Hello World");
        
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {   //Add a player force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime,0,0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<gamemanager>().EndGame();
        }
        
    }
}
