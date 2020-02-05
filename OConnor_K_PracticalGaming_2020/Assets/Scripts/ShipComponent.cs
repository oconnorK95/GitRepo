using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ShipComponent : MonoBehaviour
{
    //This class contains a template for the components which make up a spaceship

    /*
private int shipMaxValue;
private int shipMaxHealth;
private int shipCurValue;
private int shipCurHealth;
private int shipSpeed;
private int shipTurnSpeed;
private int shipDamage;
*/
    [SerializeField] public GameObject wings1, wings2, wings3, wings4, wings5;
    //[SerializeField]GameObject guns1, guns2, guns3;
    [SerializeField] public GameObject hulls1, hulls2, hulls3, hulls4, hulls5;
    [SerializeField] public GameObject thrusters1, thrusters2, thrusters3;





    //Select random element from each array, wings, guns, hulls, thrusters
    //Add each component to ship
    //Accessors mutators to update ship components, find parts in world. Use arc welder to add part (show opaque outline of component to be added)

    //GameObject curWing = wings[Random.Range(0, wings.GetLength(0))]; Use get set?



   
}
