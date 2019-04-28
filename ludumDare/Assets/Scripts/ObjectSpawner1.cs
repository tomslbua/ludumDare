using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner1 : MonoBehaviour
{
    public float objNum;
    public GameObject hochhaus;
    public SphereCollider sc;
    public GameObject fabrik;
    public GameObject einfamilienhaus;
    public GameObject supermarkt;


    private void Awake()
    {


    }

    void Start()
    {
        sc = GetComponent<SphereCollider>();
    }

    public void Hochhaus()
    {
        
            Vector3 origin = this.transform.position / 0.5f;

            Vector3 onPlanet = Random.onUnitSphere * (sc.radius * transform.localScale.x + 6);


            GameObject newGO = Instantiate(hochhaus, onPlanet, Quaternion.identity) as GameObject;
            
           



        newGO.transform.SetParent(this.transform);
            newGO.transform.LookAt(this.transform.position);
            newGO.transform.rotation = newGO.transform.rotation * Quaternion.Euler(-90, 0, 90);
            
    }
    public void Fabrik()
    {

        Vector3 origin = this.transform.position / 0.5f;

        Vector3 onPlanet = Random.onUnitSphere * (sc.radius * transform.localScale.x-2.5f);


        GameObject newGO = Instantiate(fabrik, onPlanet, Quaternion.identity) as GameObject;
        newGO.transform.SetParent(this.transform);
        newGO.transform.LookAt(this.transform.position);
        newGO.transform.rotation = newGO.transform.rotation * Quaternion.Euler(0, 180, 0);
        

    }
    public void Einfamilienhaus()
    {

        Vector3 origin = this.transform.position / 0.5f;

        Vector3 onPlanet = Random.onUnitSphere * (sc.radius * transform.localScale.x + 6);


        GameObject newGO = Instantiate(einfamilienhaus, onPlanet, Quaternion.identity) as GameObject;
        newGO.transform.SetParent(this.transform);
        newGO.transform.LookAt(this.transform.position);
        newGO.transform.rotation = newGO.transform.rotation * Quaternion.Euler(-90, 0, 90);
        
        newGO.GetComponent<MeshRenderer>().enabled = false;

    }

    public void Supermarkt()
    {

        Vector3 origin = this.transform.position / 0.5f;

        Vector3 onPlanet = Random.onUnitSphere * (sc.radius * transform.localScale.x + 6);


        GameObject newGO = Instantiate(supermarkt, onPlanet, Quaternion.identity) as GameObject;
        newGO.transform.SetParent(this.transform);
        newGO.transform.LookAt(this.transform.position);
        newGO.transform.rotation = newGO.transform.rotation * Quaternion.Euler(-90, 0, 90);
       

    }

}