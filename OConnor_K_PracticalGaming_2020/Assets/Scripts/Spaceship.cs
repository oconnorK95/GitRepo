using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Spaceship : ShipComponent
{
    private int health; //Health of ship, calculated from parts
    private int speed; //Speed of ship. calculated from parts
    private int price; //Price of ship, calculated from parts

    //private GameObject[] shipComponents = { hull, thrusters, wings };


    public Spaceship(int health, int speed, int price)
    {
        health = 100;
        speed = 20;
        price = 1000;
        // shipComponents[hull,thrusters,wings];  //A ship must have these 3 components
    }//End constructor

    public Spaceship() { }//No arg constructor

   
}