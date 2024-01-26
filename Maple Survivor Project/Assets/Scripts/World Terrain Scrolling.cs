using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldTerrainScrolling : MonoBehaviour
{
    [SerializeField] Transform playerTransform;
    Vector2Int curTilePos;
    GameObject[,] terrainTiles;

    [SerializeField] int terrainTileWidth = 3;
    [SerializeField] int terrainTileHeight = 3;

    private void Awake()
    {
        terrainTiles = new GameObject[,];
    }
}
