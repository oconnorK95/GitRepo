using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerMovement : MonoBehaviour
{

    [SerializeField]
    private Rigidbody rb;
    //private bool grounded = true;
    private int speed = 15;

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

        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(Vector3.up, ForceMode.Impulse);
        }
    }
}