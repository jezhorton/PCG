using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShip : MonoBehaviour
{

    int numOfShips = 1;
    int x, z, y;
    public GameObject ship;
    Vector3 placement;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numOfShips; i++)
        {
            x = Random.Range(-100, 100);
            y = Random.Range(-100, 100);
            z = Random.Range(-100, 100);
            placement = new Vector3(x, y, z);
            GameObject clone = Instantiate(ship, transform.position + placement, Quaternion.Euler(-90, 0, 0)) as GameObject;
            clone.transform.parent = gameObject.transform;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
