using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moverToPlayer2 : MonoBehaviour
{
    // Start is called before the first frame update
    float stepsize = 14f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W)){
            transform.position+= new Vector3(0,stepsize * Time.deltaTime,0);
        }
        else if(Input.GetKey(KeyCode.S)){
            transform.position+= new Vector3(0,-stepsize * Time.deltaTime,0);
        }
        else if(Input.GetKey(KeyCode.A)){
            transform.position+= new Vector3(-stepsize * Time.deltaTime,0,0);
        }
        else if(Input.GetKey(KeyCode.D)){
            transform.position+= new Vector3(stepsize * Time.deltaTime,0,0);
        }
    }
    
}
