using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    private float maxSpeed = 100.0f;
    private float curSpeed = 0.0f;
    private float acceleration = 0.04f;

    // Update is called once per frame
    void Update()
    {
        //Accelerate
        if (Input.GetKeyDown(KeyCode.W) && curSpeed < maxSpeed) {
            Debug.Log("W");
            curSpeed = curSpeed += acceleration;
            transform.Translate(Vector3.forward * curSpeed * Time.deltaTime);
        }//End if

        //Decelerate
        else {
            while (curSpeed > 0) {
                curSpeed -= acceleration;
            }//End while
        }//Else

    }
}
