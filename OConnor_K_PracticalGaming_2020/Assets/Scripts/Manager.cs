using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Write methods to create hulls and methods to create thrusters and wings on the hulls

public class Manager : MonoBehaviour
{
 
    // Start is called before the first frame update
    void Start()
    {
        for (int i  = 0; i < 100; i++)
        {
            //Randomise position
            GameObject new_piece = new GameObject("Component");
            new_piece.transform.position = new Vector3(Random.Range(-100.0f, 100.0f), 0f, Random.Range(-100.0f, 100.0f));
          

            ComponentControl new_component = new_piece.AddComponent<ComponentControl>();

            //Load an object (1-3 Thrusters, Hull, Wings) + a subset of the object (1-5 hull1, hull2, hull3...)
            new_component.you_are_a((ComponentControl.Slot)   UnityEngine.Random.Range(0, 3), UnityEngine.Random.Range(1,4));
            Rigidbody r = new_piece.AddComponent<Rigidbody>();
            r.isKinematic = true;
            Collider c = new_piece.AddComponent<BoxCollider>();
            c.isTrigger = true;


            //Create ship object
            //Spawn hull on the object, parent the hull to the object
            //Spawn thrusters and wings on the hull as children

            /*
            //Spawn Hull
            new_component.you_are_a((ComponentControl.Slot.Hull), UnityEngine.Random.Range(0,4));
            //Spawn Thrusters
            new_component.you_are_a((ComponentControl.Slot.Thrusters), UnityEngine.Random.Range(0, 2));
            //Spawn Wings
            new_component.you_are_a((ComponentControl.Slot.Wings), UnityEngine.Random.Range(0,4));
            */

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
