using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexTileMapGenerator : MonoBehaviour
{
    public GameObject hexPrefab;
    [SerializeField]
    int mapWidth = 25;
    int mapHeight = 5;
    public float tileXOffset = 1.8f;
    public float tileZOffset = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        CreateHexTileMap();
    }

    // Update is called once per frame
    void CreateHexTileMap()
    {
        for (int x = 0; x <= mapWidth; x++)
        {
            for (int z = 0; z <= mapHeight; z++)
            {
                GameObject temp = Instantiate(hexPrefab);

                if (z % 2 == 0)
                {
                    temp.transform.position = new Vector3(x * tileXOffset, 0, z * tileZOffset);
                }
                else
                {
                    temp.transform.position = new Vector3(x * tileXOffset + tileXOffset / 2, 0, z * tileZOffset);
                }
            }
        }
    }
}
