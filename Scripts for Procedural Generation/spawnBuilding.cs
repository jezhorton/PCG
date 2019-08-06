using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnBuilding : MonoBehaviour
{

    public List<GameObject> buildingsLevel1 = new List<GameObject>();
    public List<GameObject> buildingsLevel2 = new List<GameObject>();
    public List<GameObject> smallIslands = new List<GameObject>();
    public GameObject parent;
    float x;
    float y;
    float z;
    Vector3 offset1, offset2;
    public int maxSmallIsland;

    int townLevel;

    int numberOfSmallIslands;
    // Start is called before the first frame update
    void Start()
    {
        maxSmallIsland = spawnPlatform.maxSmallIslands;
        townLevel = spawnPlatform.levelOfTown;
        numberOfSmallIslands = Random.Range(1, maxSmallIsland);
        for (int i = 0; i < numberOfSmallIslands; i++)
        {

            x = Random.Range(-500, 800);
            y = Random.Range(-600, 800);
            z = Random.Range(-600, 800);
            offset1 = new Vector3(x, y, z);
            Instantiate(smallIslands[Random.Range(0, smallIslands.Count)], transform.position + offset1, transform.rotation, transform.parent);
        }
        if (townLevel == 0)
        {
        offset2 = new Vector3(0, 7, 0);
        Instantiate(buildingsLevel1[Random.Range(0, buildingsLevel1.Count)], transform.position + offset2, Quaternion.Euler(-90, 0, 0), transform.parent);
        }
        if (townLevel == 1)
        {
            offset2 = new Vector3(0, 3, 0);
           GameObject clone = Instantiate(buildingsLevel2[Random.Range(0, buildingsLevel2.Count)], transform.position + offset2, transform.rotation) as GameObject;
            clone.transform.parent = gameObject.transform;
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
