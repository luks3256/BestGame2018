using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody RigidBody;

    public float forwardForce = 2000f;
    public float sideForce = 500f;

	// Update is called once per frame
	void FixedUpdate ()
    {
        RigidBody.AddForce(0, 0, forwardForce * Time.deltaTime);// Privecia kuna judeti   

        if (Input.GetKey("d"))
        {
            RigidBody.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);// Privecia kuna judeti   
        }
        if (Input.GetKey("a"))
        {
            RigidBody.AddForce(-sideForce * Time.deltaTime, 0,0, ForceMode.VelocityChange);// Privecia kuna judeti  
        }

        if (RigidBody.position.y <= -1f)
        {
            FindObjectOfType<GameManagerScript>().EndGame();
        }

    }
}
