using System.Collections;

using System.Collections.Generic;

using UnityEngine;



public class MouseLookAt : MonoBehaviour

{

    public Transform player;

    float xRotation = 0.0f;

    bool shouldLook = true;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    
    // Update is called once per frame

    void Update()
    {
        if (shouldLook) {
            float xAxis = Input.GetAxis("Mouse X") * 100 * Time.deltaTime;
            float yAxis = Input.GetAxis("Mouse Y") * 100 * Time.deltaTime;

            //player.Rotate(Vector3.up * xAxis);


            //Stop player from looking too far down/up
            xRotation -= yAxis;
            xRotation = Mathf.Clamp(xRotation, -90f, 90f);

            //Allow player to look up
            transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
            player.Rotate(Vector3.up * xAxis);

        }//End shouldLook


    }//End Update
}//End MouseLookAt