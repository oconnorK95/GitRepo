using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestComponent : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        //This script acts as a basic animation, droping a ship component onto a ship
        if (Input.GetKey(KeyCode.Space))
        {
            ComponentControl x = FindObjectOfType<ComponentControl>();

            x.lock_in_place_to(transform);

        }
        
    }
}
