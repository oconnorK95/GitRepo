using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ShipCivilian : MonoBehaviour, ShipInterface
{
    enum Civilian_State { Spawning, Waiting, GetCargo, DeliverCargo, RunAway, ReturnToBase, Repairing, Dead }
    Civilian_State currently = Civilian_State.Waiting;

    int maxHealth = 100; //Base health, improved with better parts
    int curHealth = 100;
    int speed = 10; // Base speed
    string name; //Randomly generate string based on faction
    bool carryingCargo = false; //Are you carrying cargo?
    
    private ShipCivilian() { }

    
    private ShipCivilian(string name, int health, int speed, bool carryingCargo)
    {
        this.name = name;
        this.maxHealth = maxHealth;
        this.curHealth = curHealth;
        this.speed = speed;
        this.carryingCargo = false;
    }

    // Start is called before the first frame update
    void Start()
    {

    }//End start

    public void wait()
    {
        Debug.Log("Civilian waiting");
    }
    public void findTarget()
    {
        Debug.Log("Civilian looking for target");
    }
    public void attackTarget()
    {
        Debug.Log("Civilian attacking target");
    }
    public void roamAround()
    {
        Debug.Log("Civilian roaming");
    }


    // Update is called once per frame
    void Update()
    {
        switch (currently)
        {
            case Civilian_State.Spawning:
                wait();

                //Wait for some time
                currently = Civilian_State.Waiting;
                break;

            case Civilian_State.Waiting:
                //Do something


                currently = Civilian_State.GetCargo;
                break;

            case Civilian_State.GetCargo:
                //Select the closest cargo
                //if health above 20%
                //Find cargo position

                //if carrying cargo go to delivery
                break;

            case Civilian_State.DeliverCargo:
                //if health >20%
                //Go to delivery point
                break;

            case Civilian_State.RunAway:
                //pirate spotted, run
                break;

            case Civilian_State.ReturnToBase:
                //if health below 20%
                //return to base to repair
                break;

            case Civilian_State.Repairing:
                //if health low
                //and at base repair

                //If repairing and health is 100%
                //Search
                break;

            case Civilian_State.Dead:
                //destroy civilian
                break;

        }//End switch

    }//End update
}
