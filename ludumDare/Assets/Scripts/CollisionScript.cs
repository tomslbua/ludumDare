using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour
{
   
    bool script=true;
    
    
    

    private void Start()
    {
        
        
    }


    void OnTriggerEnter(Collider other) {

        if (script == true) {

            if (other.gameObject.tag == "Objects")
            {

                other.GetComponent<CollisionScript>().setbool();



                Destroy(gameObject);
                Debug.Log("trigger enter!");
            }
        }

       
        }
   public void setbool()
    {
        script = false;
    } 






}
