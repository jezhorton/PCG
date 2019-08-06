using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class creature3 : MonoBehaviour
{

    float timecounter = 0;
    public float speed = .01f;
    float width;
    int x, z, y;
    float height;
    Vector3 dir, originPos;
    // Start is called before the first frame update
    void Start()
    {
        x = Random.Range(-2000, 2000);
        z = Random.Range(4000, 7000);
        y = Random.Range(-1000, 1000);
        height = 1000;
        width = 1000;
        // originPos = new Vector3(0, 0, 7021);
        originPos = transform.localPosition;

    }

    // Update is called once per frame
    void Update()
    {
        timecounter += Time.deltaTime * speed;

        float x = Mathf.Cos(timecounter) * width;
        float y = 0;
        float z = Mathf.Sin(timecounter) * height;
        dir = new Vector3(x, y, z);

        transform.position = dir + originPos;
        transform.rotation = Quaternion.LookRotation(dir);
    }
}
