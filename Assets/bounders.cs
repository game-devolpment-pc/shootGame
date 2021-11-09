using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bounders : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if(transform.position.x > 53f){
             transform.position = new Vector3(-53f, transform.position.y,transform.position.z);
         }
         else{
             if(transform.position.x < -53f){
             transform.position = new Vector3(53f, transform.position.y,transform.position.z);
          }
         }
         if(transform.position.y > 15f){
             transform.position = new Vector3(transform.position.x,-15,transform.position.z);
         }
         if(transform.position.y < -15f){
             transform.position = new Vector3(transform.position.x,15,transform.position.z);
         }
        // transform.position = new Vector3(Mathf.Clamp(transform.position.x,-53f,53f),
        //         Mathf.Clamp(transform.position.y,-15f,15f) , transform.position.z);
    }
}
