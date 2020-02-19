using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public GameObject component_master;
    // Start is called before the first frame update
    void Start()
    {
        for (int i  = 0; i < 50;i++)
        {
            //Randomise position
            GameObject new_piece = Instantiate(component_master, new Vector3(Random.Range(-100.0f, 100.0f), 0f, Random.Range(-100.0f, 100.0f)), Quaternion.identity);

            ComponentControl new_component = new_piece.GetComponent<ComponentControl>();

            //Load an object (1-3 Thrusters, Hull, Wings) + a subset of the object (1-5 hull1, hull2, hull3...)
            new_component.you_are_a((ComponentControl.Slot)   UnityEngine.Random.Range(0, 3), UnityEngine.Random.Range(1,4));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
