using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ShipPirate : MonoBehaviour, ShipInterface
{
    enum Pirate_State {Spawning, Waiting, Searching, Attacking, Roaming, ReturnToBase, Repairing, Dead}
    Pirate_State currently = Pirate_State.Waiting;

    int maxHealth = 100; //Base health, improved with better parts
    int curHealth = 100;
    int speed = 10; // Base speed
    string name; //Randomly generate string based on faction

    //ShipPirate testPirate = new ShipPirate();
    private ShipPirate() { }

    /*private ShipPirate() {
        this.name = "Pirate";
        this.maxHealth = 100;
        this.curHealth = 100;
        this.speed = 10;
    }*/
    private ShipPirate(string name, int health, int speed)
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
        Debug.Log("Pirate waiting");
    }
    public void findTarget()
    {
        Debug.Log("Pirate looking for target");
    }
    public void attackTarget()
    {
        Debug.Log("Pirate attacking target");
    }
    public void roamAround()
    {
        Debug.Log("Pirate roaming");
    }


    // Update is called once per frame
    void Update()
    {
        switch (currently) {
            case Pirate_State.Spawning:
                wait();

                //Wait for some time
                currently = Pirate_State.Waiting;
                break;

            case Pirate_State.Waiting:
                //Do something
                

                currently = Pirate_State.Searching;
                break;

            case Pirate_State.Searching:
                //if health above 20%
                //Find Civilians to kill

                //else return to base
                break;

            case Pirate_State.Attacking:
                //if enemy spotted, attack
                //Else search again
                break;

            case Pirate_State.Roaming:
                //if nothing found in area
                //Go somewhere else
                break;

            case Pirate_State.ReturnToBase:
                //if health low
                //return to base to repair
                break;

            case Pirate_State.Repairing:
                //if health low
                //and at base repair

                //If repairing and health is 100%
                //Search
                break;

            case Pirate_State.Dead:
                //destroy pirate
                break;
            
        }//End switch

    }//End update
}
