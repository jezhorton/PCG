using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Everything : MonoBehaviour
{

    public int noOfAnimals;
    public static int animals;
    public GameObject whale, turtle;
    int x, z, y, rand;
    Vector3 placement;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < noOfAnimals; i++)
        {
            rand = Random.Range(0, 10);
            if (rand <= 5)
            {
                x = Random.Range(-5000, 8000);
                y = Random.Range(-3000, 5000);
                z = Random.Range(-6000, 8000);
                placement = new Vector3(x, y, z);
                Instantiate(turtle, placement,  Quaternion.identity);
            }
            if (rand > 5)
            {
                x = Random.Range(-5000, 8000);
                y = Random.Range(-6000, 8000);
                z = Random.Range(-6000, 8000);
                placement = new Vector3(x, y, z);
                Instantiate(whale, placement, Quaternion.identity);
            }

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
