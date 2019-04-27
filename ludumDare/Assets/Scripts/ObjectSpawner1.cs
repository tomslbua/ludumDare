using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner1 : MonoBehaviour
{

    //public GameObject[] objectsToSpawn;
    //public float spawnRadius = 10.0f;
    //public int numberOfObjects = 10;

    //// Use this for initialization
    //void Update()
    //{
    //    for (int i = 0; i < numberOfObjects; i++)
    //    {
    //        GameObject objectToSpawn = objectsToSpawn[Random.Range(0, objectsToSpawn.Length)];

    //        Vector2 spawnPositionV2 = Random.insideUnitCircle * spawnRadius;

    //        Vector3 spawnPosition = new Vector3(spawnPositionV2.x, 0.0f, spawnPositionV2.y);

    //        Vector3 transformOffsetSpawnPosition = transform.position + spawnPosition;

    //        RaycastHit hit;
    //        if (Physics.Raycast(transformOffsetSpawnPosition, Vector3.down, out hit))
    //        {

    //            Vector3 finalSpawnPosition = hit.point;
    //            Instantiate(objectToSpawn, finalSpawnPosition, Quaternion.identity);
    //        }
    //    }
    //}

    //    public int numObjects = 10;
    //    public GameObject prefab;
    //    public SphereCollider sc;

    //    void Start()
    //    {
    //        sc = GetComponent<SphereCollider>();

    //        Vector3 center = transform.position;
    //        for (int i = 0; i < numObjects; i++)
    //        {
    //            Vector3 pos = RandomCircle(center, sc.radius);
    //            Quaternion rot = Quaternion.FromToRotation(Vector3.forward, center +pos);

    //            Instantiate(prefab, pos,rot);
    //        }
    //    }

    //    Vector3 RandomCircle(Vector3 center, float radius)
    //    {
    //        //float ang = Random.value * 360;
    //        Vector3 pos;

    //        //pos.x = Random.Range(radius*transform.localScale.x, -radius * transform.localScale.x);
    //        //pos.y = Random.Range(radius * transform.localScale.x, -radius * transform.localScale.x);
    //        //pos.z = Random.Range(radius * transform.localScale.x, -radius * transform.localScale.x);
    //        //pos.x = center.x + transform.localScale.x* radius * Mathf.Sin(ang * Mathf.Deg2Rad);
    //        //pos.y = center.y + transform.localScale.x * radius * Mathf.Cos(ang * Mathf.Deg2Rad);
    //        //pos.z = center.z;
    //        return pos;
    //    }
    //}
    public float objNum;
    public GameObject prefab;
    public SphereCollider sc;
    

    void Start()
    {
        sc = GetComponent<SphereCollider>();

        for (int i = 0; i < objNum; i++)
        {
            Vector3 origin = this.transform.position / 0.5f;

            Vector3 onPlanet = Random.onUnitSphere * (sc.radius * transform.localScale.x + 6);


            GameObject newGO = Instantiate(prefab, onPlanet, Quaternion.identity) as GameObject;
            newGO.transform.SetParent(this.transform);
            newGO.transform.LookAt(this.transform.position);
            newGO.transform.rotation = newGO.transform.rotation * Quaternion.Euler(-90, 0, 90);
            Debug.Log(sc.radius);
        }
    }

}