using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Write methods to create hulls and methods to create thrusters and wings on the hulls

public class Manager : MonoBehaviour
{
    //Array list of components for observer


    // Start is called before the first frame update
    void Start()
    {


        for (int i  = 0; i < -1; i++)
        {
            //Randomise position
            GameObject new_piece = new GameObject("Component");
            
            new_piece.transform.position = new Vector3(Random.Range(-100.0f, 100.0f), 0f, Random.Range(-100.0f, 100.0f));

            ComponentControl new_component = new_piece.AddComponent<ComponentControl>();
            
            //Load an object (1-3 Thrusters, Hull, Wings) + a subset of the object (1-5 hull1, hull2, hull3...)
            new_component.you_are_a((ComponentControl.Slot)UnityEngine.Random.Range(0, 3), UnityEngine.Random.Range(1, 4));
            Rigidbody r = new_piece.AddComponent<Rigidbody>();
            r.isKinematic = true;
            Collider c = new_piece.AddComponent<BoxCollider>();
            c.isTrigger = true;

        }

        for (int i = 0; i < 20; i++)
        {

            GameObject cargo = new GameObject();
            cargo.transform.position = new Vector3(Random.Range(-100.0f, 100.0f), 0f, Random.Range(-100.0f, 100.0f));
        }//End for

    }

    /*
        public void addToArray(Component component)
        {
            arrayOfComponents.Add(component);
        }

             public void removeFromArray(Component component)
        {
            arrayOfComponents.Remove(component);
        }
    */


    // Update is called once per frame
    void Update()
    {
        
    }
}
