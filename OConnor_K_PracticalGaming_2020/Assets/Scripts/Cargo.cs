using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cargo : MonoBehaviour
{

    int value = 100;


    void Start(){
        Vector3 cargoPos = default(Vector3);
        transform.position = cargoPos;
        Debug.Log("Cargo position: " + cargoPos);
    }

}
