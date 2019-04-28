using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour
{
    public GameObject sphere;
    SphereCollider sc;
    bool script=true;
    private void Start()
    {
        sc = sphere.GetComponent<SphereCollider>();
        
    }


    void OnTriggerEnter(Collider other) {

        if (script == true) { 

        if (other.gameObject.tag == "Objects")
        {

            Vector3 onPlanet = Random.onUnitSphere * (sc.radius * transform.localScale.x + 6);
            transform.position = onPlanet;
            transform.LookAt(this.transform.position);
            transform.rotation = transform.rotation * Quaternion.Euler(-90, 0, 90);

            Debug.Log("trigger enter!");
        }

       else
        {

            gameObject.GetComponent<MeshRenderer>().enabled = true;
            Debug.Log("funkt!");
            script = false;
            

            

            
        }
        }

       
        }
    

    



}
