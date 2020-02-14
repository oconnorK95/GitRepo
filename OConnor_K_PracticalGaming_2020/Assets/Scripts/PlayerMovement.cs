using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerMovement : MonoBehaviour
{

    [SerializeField]
    private Rigidbody rb;
    //private bool grounded = true;
    private int speed = 15;
    bool shouldJump = true;
    public float timer = 20;

    public CharacterController controller;

    // Start is called before the first frame update

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //rb.AddForce(Vector3.down * Time.deltaTime, ForceMode.Acceleration);
        //rb.transform.Translate(Vector3.down * Time.deltaTime);

        Vector3 move = transform.right * Input.GetAxis("Horizontal") + transform.forward * Input.GetAxis("Vertical");

        //rb.AddForce(move * Time.deltaTime);
        controller.Move(move * speed * Time.deltaTime);

        
        if (Input.GetKey(KeyCode.Space) && shouldJump)
        {
            rb.AddForce(Vector3.up, ForceMode.Impulse);
            if (timer > 0) {
                timer -= Time.deltaTime;
                Debug.Log("Timer decreasing");
            }//End if
            else {
                timer = 20;
                Debug.Log("Timer reset to 1000ms");
            }//End else
        }//End if
        
        
    }
}