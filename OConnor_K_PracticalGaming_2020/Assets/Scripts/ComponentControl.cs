using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponentControl : MonoBehaviour
{   enum Component_State {  Nothing, Animating }
    Component_State currently = Component_State.Nothing;


    float ANIMATION_TIME = 1.5f; //Originally 2.0f
    float timer;
    float vertical_height_at_start_of_animation = 0.05f;  //This was originally 5, changed due to scale Blender3d scale issues

    Vector3 start_position,end_position;
    enum Slot { Thrusters, Hull, Wings}

    Slot thisGoes;


    string model_name = "thrusters1prefab";
    //string model_name = "wings1prefab";
    string hull1 = "hull2prefab";
    string wings1 = "wings1prefab";

    // Start is called before the first frame update
    void Start() 
    {
        //When I move the ship that starts in the scene, I can no longer instantiate objects
        //Because objects try to instantiate onto the base hull? Instantiate testcomponent script onto new empty gameobject prefab
        //Instantiate a hull onto the empty object + thrusters and wings

        GameObject test =(GameObject) Instantiate(Resources.Load(model_name),transform);
        GameObject ship1hull = (GameObject)Instantiate(Resources.Load(hull1), transform);
        GameObject ship1wings = (GameObject)Instantiate(Resources.Load(wings1), transform);

    }

    internal void lock_in_place_to(Transform spaceship)
    {
        start_position = spaceship.position + vertical_height_at_start_of_animation * Vector3.up;
        end_position = spaceship.position;
        transform.parent = spaceship;
        timer = 0;
        currently = Component_State.Animating;


    }

    // Update is called once per frame
    void Update()
    {

        switch (currently) {

            case Component_State.Animating:

                timer += Time.deltaTime;
                transform.localPosition = Vector3.Lerp(start_position, end_position, timer / ANIMATION_TIME);
                if (timer > ANIMATION_TIME)
                {
                    currently = Component_State.Nothing;
                    transform.localPosition = end_position;

                }

                break;


        }


        
    }
}
