using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class onMouseDestroy : MonoBehaviour {

    ObjectSpawner1 objectspawner;
    public AudioSource baumweg;
 


    private void Start()
    {
        objectspawner = ObjectSpawner1.Instance;
        
    }

    private void Update()
    {
       
    }


    private void OnMouseDown()
    {
        if (gameObject.tag == "spawn") {
            objectspawner.holzcheck = false;
            
           
            Destroy(gameObject);

            objectspawner.treeTracker--;
        }
        }

   

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Objects")
        {
            Destroy(gameObject);
            
            objectspawner.treeTracker--;
        }
    }
}
