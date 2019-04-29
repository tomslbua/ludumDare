using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour
{
   
    bool script=true;
    ObjectSpawner1 objectspawner;
    
    

    private void Start()
    {
        objectspawner = ObjectSpawner1.Instance;
        
    }


    void OnTriggerEnter(Collider other) {

        if (script == true) {

            if (other.gameObject.tag == "Objects")
            {

                other.GetComponent<CollisionScript>().setbool();



                Destroy(gameObject);
                objectspawner.respawn(name);
                Debug.Log("trigger enter!");
            }
        }

       
        }
   public void setbool()
    {
        script = false;
    } 






}
