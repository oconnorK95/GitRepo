using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//For use in - ENFORCER - CIVILIAN subclasses

//Game loop:
//Civilians search for cargo
//Pirates hunt civilians
//Enforcers hunt pirates

//Advanced loop (maybe later): 
//Cargo makes space station more wealthy, creates more cargo
//Pirate population booms, civilians and cargo population declines

public interface ShipInterface 
{

    void wait();
    void findTarget();
    void attackTarget();
    void roamAround();

}
