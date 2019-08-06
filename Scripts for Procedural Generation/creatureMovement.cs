using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class creatureMovement : MonoBehaviour
{

    float timecounter = 0;
    public float speed = 0.1f;
    float width;
    float height;
    Vector3 dir, originPos;
    // Start is called before the first frame update
    void Start()
    {

        height = 4000;
        width = 4000;
        // originPos = new Vector3(0, 0, 7021);
        originPos = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        timecounter += Time.deltaTime*speed;

        float x = Mathf.Cos(timecounter)*width;
        float y = 0;
        float z = Mathf.Sin(timecounter)*height;
        dir = new Vector3(x, y, z);

        transform.position = dir + originPos;
        transform.rotation = Quaternion.LookRotation(dir);
    }
}
