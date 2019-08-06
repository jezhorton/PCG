using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnPlanet : MonoBehaviour
{
    //[SerializeField] ScriptableObject shapeSettings;
    //public GameObject[] planets;
    public int planetNumber;

    // Start is called before the first frame update
    float x;
    float y;
    float z;
    Vector3[] pos;
    Vector3 testvect;

    int i;
    GameObject[] planets;
    public List<ColourSettings> colours = new List<ColourSettings>();
    public List<ShapeSettings> shapes = new List<ShapeSettings>();
    void Start()
    {
        planets = new GameObject[planetNumber];
        for (i = 0; i < planetNumber; i++)

        {
            planets[i] = new GameObject();
            if (planetNumber > 15)
            {
                x = Random.Range(-7000, 8000);
                y = Random.Range(-7000, 8000);
                z = Random.Range(-1000, 2000);
                testvect = new Vector3(x, y, z);
            }
            else
            {
                x = Random.Range(-1000, 2000);
                y = Random.Range(-2000, 1000);
                z = Random.Range(-1000, 2000);
                testvect = new Vector3(x, y, z);
            }
            planets[i].AddComponent<Planet>();
            var plan = planets[i].GetComponent<Planet>();
            plan.shapeSettings = (shapes[Random.Range(0, shapes.Count)]);
            plan.colourSettings = (colours[Random.Range(0, colours.Count)]);

            Debug.Log(i);
            planets[i].transform.position = testvect;


        }
        Debug.Log(pos[i]);
    }

    // Update is called once per frame
    void Update()
    {

        for (i = 0; i <= planetNumber;i++) {
            planets[i].transform.position =  testvect;

        }
    }
}
