using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour {

    //public GameObject[] objectsToSpawn;
    //public float spawnRadius = 10;
    //public int numberOfObjects = 10;

    //private void Start()
    //{
    //    for (int i = 0; i < 10; i++)
    //    {
    //        GameObject objectToSpawn = objectsToSpawn[Random.Range(0, 10)];

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

    public int numObjects = 10;
    public GameObject prefab;

    void Start()
    {
        Vector3 center = transform.position;
        for (int i = 0; i < numObjects; i++)
        {
            Vector3 pos = RandomCircle(center, 5.0f);
            Quaternion rot = Quaternion.FromToRotation(Vector3.forward, center - pos);
            Instantiate(prefab, pos, rot);
        }
    }

    Vector3 RandomCircle(Vector3 center, float radius)
    {
        float ang = Random.value * 360;
        Vector3 pos;
        pos.x = center.x + radius * Mathf.Sin(ang * Mathf.Deg2Rad);
        pos.y = center.y + radius * Mathf.Cos(ang * Mathf.Deg2Rad);
        pos.z = center.z;
        return pos;
    }
}
