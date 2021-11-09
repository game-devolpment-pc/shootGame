using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component moves its object when the player clicks the arrow keys.
 */
public class KeyboardMover: MonoBehaviour {
    [Tooltip("Speed of movement, in meters per second")]
     float stepsize = 14;

    void Update() {
        if(Input.GetKey(KeyCode.UpArrow)){
            transform.position+= new Vector3(0,stepsize * Time.deltaTime,0);
        }
        else if(Input.GetKey(KeyCode.DownArrow)){
            transform.position+= new Vector3(0,-stepsize * Time.deltaTime,0);
        }
        else if(Input.GetKey(KeyCode.LeftArrow)){
            transform.position+= new Vector3(-stepsize * Time.deltaTime,0,0);
        }
        else if(Input.GetKey(KeyCode.RightArrow)){
            transform.position+= new Vector3(stepsize * Time.deltaTime,0,0);
        }
    }
}
        //transform.Translate(movementVector);
        // NOTE: "Translate(movementVector)" uses relative coordinates - 
        //       it moves the object in the coordinate system of the object itself.
        // In contrast, "transform.position += movementVector" would use absolute coordinates -
        //       it moves the object in the coordinate system of the world.
        // It makes a difference only if the object is rotated.

