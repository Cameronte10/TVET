using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
    public GameObject tilePrefab;
    public int width = 10, height = 10;
    public float spacing = .155f;
    private Tile[,] tiles;
    
    Tile SpawnTile(Vector3 pos)
    {
        GameObject clone = Instantiate(tilePrefab);
        clone.transform.position = pos;
        Tile currentTile = clone.GetComponent<Tile>();
        return currentTile;
    }

    void GenerateTiles()
    {
       tiles = new Tile[width, height];

    }
}
