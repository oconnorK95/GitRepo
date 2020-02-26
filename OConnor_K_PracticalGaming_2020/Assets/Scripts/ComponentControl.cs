using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//TODO: State for AVAILABLE, CARRIED, FIXED
//TODO: Randomise material of components
//TODO: Randomise buildings/space-ports

public class ComponentControl : MonoBehaviour
{
    enum Component_State { None, Spawning, Available, Carried, Animating, Fixed, Fade_Out}
    Component_State currently = Component_State.None;
    private bool is_a_dummy;
    float ANIMATION_TIME = 1.5f; //Originally 2.0f
    float timer;
    float vertical_height_at_start_of_animation = 0.05f;  //This was originally 5, changed due to scale Blender3d scale issues

    //Start and End position for component animation
    Vector3 start_position,end_position;
    internal enum Slot { Thrusters, Hull, Wings}
    
    Slot thisGoes;

    internal void you_are_a_dummy()
    {

        is_a_dummy = true;

    }

    int component_level;
    List<string> filename_start;
    private bool model_loaded = false;
    private float scale_down_for_carry = 0.03f;
    private float carry_rotate_speed = 180;

    // Start is called before the first frame update
    void Start() 
    {
        filename_start = new List<string>();
        filename_start.Add("thrusters");
        filename_start.Add("hull");
        filename_start.Add("wings");
    }

    void removeComponent() {

        //If a new component is added to the ship

        //Get its slot type (Hull, Thrusters, Wings)

        //Fade out the opacity of the old component and delete it
        currently = Component_State.Fade_Out;
    }


    internal void lock_in_place_to(Transform spaceship)
    {
        //New component has transform set to above the ship
        start_position = spaceship.position + vertical_height_at_start_of_animation * Vector3.up;
        //End position is set to the ships position
        end_position = spaceship.position;
        //Ship is the parent for the transform
        transform.parent = spaceship;
        timer = 0;
        //Set state to Animating
        currently = Component_State.Animating;

    }//End lock_in_place_to

    // Update is called once per frame
    void Update()
    {

        //Folded Component_State to tidy up code
        #region
        switch (currently) {

            case Component_State.Spawning:

                if (!model_loaded)
                {
                    //Find an object to spawn. "Filename" + "number" eg "thrusters1"
                    string filename = filename_start[(int)thisGoes] + component_level.ToString();
                    //new_component is an object loaded from resources
                    GameObject new_component = (GameObject)Instantiate(Resources.Load(filename), transform, false);
                    model_loaded = true;
                    currently = Component_State.Available;
                }

                break;//End Spawning

            case Component_State.Available:

                if (is_a_dummy)
                {

                    Color currentColour = GetComponent<Renderer>().material.color;

                    Color newColour = new Color(currentColour.r, currentColour.g, currentColour.b, 0.2f);

                    GetComponent<Renderer>().material.color = newColour;
                }
                
                //When an object spawns and has a model assigned to it
                //Set the object to available
                

                break;//End Available


            case Component_State.Animating:

                timer += Time.deltaTime;
                transform.localPosition = Vector3.Lerp(start_position, end_position, timer / ANIMATION_TIME);
                if (timer > ANIMATION_TIME)
                {
                    currently = Component_State.Spawning;
                    transform.localPosition = end_position;

                }

                break;//End Animating

            case Component_State.Fade_Out:

                //If slot is occupied AND a new object is entering the slot
                //Fade out and destroy the old component

                /*
                for (int i = 0; i > 100; i++) {
                    Slot.variableComponent.GetComponent<Renderer>().material.color.a = 0.5f;
                }
               */

                break;//End Fade_Out

            case Component_State.Fixed:

                //If a component has been added to a ship
                //Set the component to fixed
                

                break;//End Fixed

            case Component_State.Carried:

                //If an object is available AND the player collides with it
                //Pick up the object, set it to carried

                transform .Rotate(Vector3.forward, carry_rotate_speed * Time.deltaTime);
                break;//End Fixed

        }//End switch
        #endregion
    }//End Update


    internal void you_are_a(Slot placement, int level)
    {
        //Set slot
        thisGoes = placement;
        //Set level(tier) of item
        component_level = level;
        //Set state to spawning
        currently = Component_State.Spawning;

    }//End you_are_a

    internal void you_are_a_thruster(Slot placement, int level, GameObject parent)
    {
        //Set parent
        transform.parent = parent.transform;

        //Set slot
        thisGoes = placement;

        //Set level(tier) of item
        component_level = level;

        //Set state to spawning
        currently = Component_State.Spawning;
    }//End you_are_a_thruster

    void OnTriggerEnter(Collider col)
    {
        Character_pick_up the_one_picking_me_up = col.transform.GetComponent<Character_pick_up>();
        if (the_one_picking_me_up)
        {
            if (the_one_picking_me_up.can_pick_me_up())
            {
                currently = Component_State.Carried;
                transform.parent = the_one_picking_me_up.transform;
                the_one_picking_me_up.you_are_now_carrying(this);
                transform.localScale = scale_down_for_carry * transform.localScale;
                transform.localPosition = new Vector3(1.0f, 0f, 1.0f);
            }
 

        }

    }



    internal void you_are_a_wing(Slot placement, int level, GameObject parent)
    {
        //Set parent
        transform.parent = parent.transform;

        //Set slot
        thisGoes = placement;

        //Set level(tier) of item
        component_level = level;

        //Set state to spawning
        currently = Component_State.Spawning;
    }//End you_are_a_wing

}//End Component Control
