using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ShipEnforcer : MonoBehaviour, ShipInterface
{
    enum Enforcer_State { Spawning, Waiting, Searching, Attacking, Roaming, ReturnToBase, Repairing, Dead }
    Enforcer_State currently = Enforcer_State.Waiting;

    int maxHealth = 100; //Base health, improved with better parts
    int curHealth = 100;
    int speed = 10; // Base speed
    string name; //Randomly generate string based on faction

    private ShipEnforcer() { }

    
    private ShipEnforcer(string name, int health, int speed)
    {
        this.name = name;
        this.maxHealth = maxHealth;
        this.curHealth = curHealth;
        this.speed = speed;
    }

    // Start is called before the first frame update
    void Start()
    {

    }//End start

    public void wait()
    {
        Debug.Log("Enforcer waiting");
    }
    public void findTarget()
    {
        Debug.Log("Enforcer looking for target");
    }
    public void attackTarget()
    {
        Debug.Log("Enforcer attacking target");
    }
    public void roamAround()
    {
        Debug.Log("Enforcer roaming");
    }


    // Update is called once per frame
    void Update()
    {
        switch (currently)
        {
            case Enforcer_State.Spawning:
                wait();

                //Wait for some time
                currently = Enforcer_State.Waiting;
                break;

            case Enforcer_State.Waiting:
                //Do something


                currently = Enforcer_State.Searching;
                break;

            case Enforcer_State.Searching:
                //if health above 20%
                //Find Pirates to kill

                //else return to base
                break;

            case Enforcer_State.Attacking:
                //if enemy spotted, attack
                //Else search again
                break;

            case Enforcer_State.Roaming:
                //if nothing found in area
                //Go somewhere else
                break;

            case Enforcer_State.ReturnToBase:
                //if health low
                //return to base to repair
                break;

            case Enforcer_State.Repairing:
                //if health low
                //and at base repair

                //If repairing and health is 100%
                //Search
                break;

            case Enforcer_State.Dead:
                //destroy Enforcer
                break;

        }//End switch

    }//End update
}
