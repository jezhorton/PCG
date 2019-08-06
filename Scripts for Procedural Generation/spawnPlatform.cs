using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnPlatform : MonoBehaviour
{

    float x;
    float y;
    float z;
    int Townlevel;
    public int MaximumSmallIslands;
    public static int levelOfTown;
    public static int maxSmallIslands;
    public List<GameObject> platforms = new List<GameObject>();
    Vector3 offset;
    public int numberOfIslands;
    // Start is called before the first frame update
    void Start()
    {
        maxSmallIslands = MaximumSmallIslands;
        for (int i = 0; i < numberOfIslands; i++)
        {

            x = Random.Range(200, 1000);
            y = Random.Range(100, 1000);
            z = Random.Range(-700, 700);
            offset = new Vector3(x, y, z);


            GameObject clone = Instantiate(platforms[Random.Range(0, platforms.Count)], transform.position + offset, Quaternion.Euler(-90, 0, 0)) as GameObject;
            clone.transform.parent = gameObject.transform;
            Townlevel = Random.Range(0, 20);
            if (Townlevel > 10)
            {
                levelOfTown = 1;
            }
            if (Townlevel < 10)
            {
                levelOfTown = 0;
            }

        }
    }
    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < numberOfIslands; i++)
        {

        }
    }
}
