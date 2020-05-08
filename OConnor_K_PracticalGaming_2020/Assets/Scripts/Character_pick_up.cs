using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_pick_up : MonoBehaviour
{
  //  Material m;
  //  Texture2D our_texture;

    ComponentControl I_am_carrying;
     
    ComponentControl basic_hull, basic_thruster, basic_wing;
    // Start is called before the first frame update
    void Start()
    {
     
        
        GameObject new_piece = new GameObject("Dummy Hull");
        new_piece.transform.parent = transform;
        new_piece.transform.localPosition = new Vector3(1, 0, 1);
        basic_hull = new_piece.AddComponent<ComponentControl>();
        //Load an object (1-3 Thrusters, Hull, Wings) + a subset of the object (1-5 hull1, hull2, hull3...)
        basic_hull.you_are_a(ComponentControl.Slot.Hull, 1);
        basic_hull.transform.localScale = new Vector3(.1f, 0.1f, 0.1f);
        basic_hull.you_are_a_dummy();
      
        /*
        GameObject new_piece1 = new GameObject("Dummy Thruster");
        new_piece1.transform.parent = transform;
        //new_piece1.transform.localPosition = new Vector3(1, 0, 1);
        basic_thruster = new_piece.AddComponent<ComponentControl>();
        basic_thruster.you_are_a(ComponentControl.Slot.Thrusters, 1);
        basic_thruster.transform.localScale = new Vector3(.1f, 0.1f, 0.1f);
        basic_thruster.you_are_a_dummy();
        */
        
        GameObject new_piece2 = new GameObject("Dummy Wing");
        new_piece2.transform.parent = transform;
        new_piece2.transform.localPosition = new Vector3(1, 0, 1);
        basic_wing = new_piece.AddComponent<ComponentControl>();
        basic_wing.you_are_a(ComponentControl.Slot.Wings, 1);
        basic_wing.transform.localScale = new Vector3(.1f, 0.1f, 0.1f);
        basic_wing.you_are_a_dummy();

        basic_wing.transform.SetParent(basic_hull.transform);
        basic_thruster.transform.SetParent(basic_hull.transform);

        
    }//End Start

    private void Update()
    {
        //basic_hull.transform.Rotate(0f,2f,0f);
        
    }


    internal bool can_pick_me_up()
    {
        return I_am_carrying == null;
    }

    internal void you_are_now_carrying(ComponentControl componentControl)
    {
        I_am_carrying = componentControl;
    }
}
