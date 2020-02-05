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

        if (Input.GetKey(KeyCode.Space))
        {
            ComponentControl x = FindObjectOfType<ComponentControl>();

            x.lock_in_place_to(transform);

        }
        
    }
}
