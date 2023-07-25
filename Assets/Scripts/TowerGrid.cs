using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerGrid : MonoBehaviour
{
    [SerializeField] private GameObject gridOb;

    [SerializeField] private int xSize = 10;
    [SerializeField] private int ySize = 5;

    public bool[,] grid;
    public GameObject[,] gridObjects;
    private void Start()
    {
        grid = new bool[xSize, ySize];
        gridObjects = new GameObject[xSize, ySize];
        for (int i = 0; i < xSize; i++)
        {
           for (int j = 0; j < ySize; j++)
            {
                gridObjects[i,j] = Instantiate(gridOb, new Vector3(2.5f * i, transform.position.y ,2.5f * j), Quaternion.identity);
            }
        }
    }
}
