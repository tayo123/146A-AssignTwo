using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // Update is called once per frame
    private void FixedUpdate () {
        // add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        //float x = Input.GetAxis("Horizontal") * Time.deltaTime * 15f;

        //rb.MovePosition(rb.position + Vector3.right * x);

        if (Input.GetAxis("Horizontal") > 0) 
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetAxis("Horizontal") < 0)
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f) {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
