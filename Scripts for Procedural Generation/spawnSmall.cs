using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnSmall : MonoBehaviour
{
    public List<GameObject> prefabs = new List<GameObject>();

    Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = new Vector3(3, 7, 0);


       GameObject clone = Instantiate(prefabs[Random.Range(0, prefabs.Count)], transform.position + offset, transform.rotation) as GameObject;
        clone.transform.parent = gameObject.transform;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
