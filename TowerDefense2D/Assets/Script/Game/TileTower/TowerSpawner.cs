using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerSpawner : MonoBehaviour
{
    public static TowerSpawner Instance;
    public Tower tower;
    void Start()
    {
        Instance = this;
    }

    public void SpawnTower(Vector3 pos)
    {
        Tower tw = Instantiate(tower);
        tw.transform.position = pos;
    }
}
