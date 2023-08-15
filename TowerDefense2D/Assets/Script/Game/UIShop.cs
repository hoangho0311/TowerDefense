using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIShop : MonoBehaviour
{
    public UITowerItem itemPrefab;
    public List<TowerItemSO> database;
    public Transform parentItem;
    public TileTower currentTile;

    private void Start()
    {
        SpawnItem();
    }

    public TileTower GetTileTower()
    {
        return currentTile;
    }

    public void SetTileTower(TileTower current)
    {
        this.currentTile = current;
    }

    private void SpawnItem()
    {
        foreach(var data in database)
        {
            var item = Instantiate(itemPrefab, parentItem);
            item.SetItem(data);
        }
    }

    public void CloseShop()
    {
        gameObject.SetActive(false);
    }
}
