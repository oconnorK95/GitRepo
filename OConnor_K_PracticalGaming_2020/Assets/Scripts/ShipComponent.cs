using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ShipComponent : MonoBehaviour
{
    //This class contains a template for the components which make up a spaceship
    //Essential: Hull, Side + Rear Thrusters, Wings
    //NonEssential: WarpDrive, Hyperdrive, Accents, Guns
    //These components will have values associated with them which will add to the ships total stats. E.g. a hull will add health, thrusters add speed


    private int shipMaxValue;
    private int shipMaxHealth;
    private int shipCurValue;
    private int shipCurHealth;
    private int shipSpeed;
    private int shipTurnSpeed;
    private int shipDamage;

    private GameObject[] wings;
    //hulls.Add(wings1);
    //hulls.Add(wings2);
    //hulls.Add(wings3);

    private GameObject[] guns;
    //hulls.Add(guns1);
    //hulls.Add(guns2);
    //hulls.Add(guns3);


    private GameObject[] hulls;
    //hulls.Add(hull1);
    //hulls.Add(hull2);
    //hulls.Add(hull3);

    private GameObject[] rearThruster;
    //hulls.Add(rearThruster1);
    //hulls.Add(rearThruster2);
    //hulls.Add(rearThruster3);

    private GameObject[] thrusters;
    //hulls.Add(thrusters1);
    //hulls.Add(thrusters2);
    //hulls.Add(thrusters3);

}
