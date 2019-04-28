using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onMouseDestroy : MonoBehaviour {

    ObjectSpawner1 objectspawner;


    private void Start()
    {
        objectspawner = ObjectSpawner1.Instance;
    }

    
    private void OnMouseDown()
    {
        if (gameObject.tag == "spawn") {
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
