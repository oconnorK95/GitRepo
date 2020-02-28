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
      //  m = Resources.Load<Material>("rrrrr");
        //Randomise position
        GameObject new_piece = new GameObject("Dummy Hull");
        new_piece.transform.parent = transform;

        new_piece.transform.localPosition = new Vector3(1, 0, 1);
        basic_hull = new_piece.AddComponent<ComponentControl>();
        //Load an object (1-3 Thrusters, Hull, Wings) + a subset of the object (1-5 hull1, hull2, hull3...)
        basic_hull.you_are_a(ComponentControl.Slot.Hull, 1);
        basic_hull.you_are_a_dummy();



        new_piece = new GameObject("Dummy Thruster");
        new_piece.transform.parent = transform;

        new_piece.transform.localPosition = new Vector3(1, 0, 1);
        basic_hull = new_piece.AddComponent<ComponentControl>();

        basic_hull.you_are_a(ComponentControl.Slot.Thrusters, 1);


        new_piece = new GameObject("Dummy Wing");
        new_piece.transform.parent = transform;

        new_piece.transform.localPosition = new Vector3(1, 0, 1);
        basic_hull = new_piece.AddComponent<ComponentControl>();


        basic_hull.you_are_a(ComponentControl.Slot.Wings, 1);
    }//End Start


    internal bool can_pick_me_up()
    {
        return I_am_carrying == null;
    }

    internal void you_are_now_carrying(ComponentControl componentControl)
    {
        I_am_carrying = componentControl;
    }
}
