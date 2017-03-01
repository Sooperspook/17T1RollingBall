using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float torqueSpeed;
    private Rigidbody player;

    void Start()
    {
        player = GetComponent<Rigidbody>();
    }

void FixedUpdate ()
    {

        // Using torque to move the player.
        // moveForeward also moves backward, moveTurn causes it to spin
        // problem: once it starts moving, because axes move, hard to control

        float moveForeward = Input.GetAxis("Vertical");
        player.AddTorque(transform.forward * torqueSpeed * moveForeward);

        float moveTurn = Input.GetAxis("Horizontal");
        player.AddTorque(transform.up * torqueSpeed * moveTurn);
    }

    void OnTriggerEnter(Collider other)
    {
       if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
        }

   
    }
    
}

