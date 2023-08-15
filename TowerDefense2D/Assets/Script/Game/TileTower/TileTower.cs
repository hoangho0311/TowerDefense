using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileTower : MonoBehaviour
{
    public void TileTowerOnClicked()
    {
        Debug.Log("Spawn tower");
        UIManager.Instance.ShowShop();
        UIManager.Instance.shopUI.SetTileTower(this);
    }

    public void DestroyTileTower()
    {
        Destroy(gameObject);
    }
}
