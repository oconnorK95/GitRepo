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
    [SerializeField]GameObject wings1, wings2, wings3;
    [SerializeField]GameObject guns1, guns2, guns3;
    [SerializeField]GameObject hulls1, hulls2, hulls3;
    [SerializeField]GameObject thrusters1, thrusters2, thrusters3;

    private GameObject[] wings;
    //public GameObject wings.Add(wings1);
    //public GameObject = wings[0];
    //wings.Add(wings2);
    //wings.Add(wings3);

    private GameObject[] guns;
    //guns.Add(guns1);
    //guns.Add(guns2);
    //guns.Add(guns3);

    private GameObject[] hulls;
    //hulls.Add(hull1);
    //hulls.Add(hull2);
    //hulls.Add(hull3);

    private GameObject[] thrusters;
    //thrusters.Add(thrusters1);
    //thrusters.Add(thrusters2);
    //thrusters.Add(thrusters3);

    //Select random element from each array, wings, guns, hulls, thrusters
    //Add each component to ship
    //Accessors mutators to update ship components, find parts in world. Use arc welder to add part (show opaque outline of component to be added)

    //GameObject curWing = wings[Random.Range(0, wings.GetLength(0))]; Use get set?

}
