using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public int cost = 200;

    private void Awake()
    {
        Instance = this;

    }

    public int GetCost()
    {
        return cost;
    }

    public void AddCost(int value)
    {
        cost += value;
    }

    public void Subtract(int value)
    {
        cost -= value;
    }
}
