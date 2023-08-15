using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UITowerItem : MonoBehaviour
{
    private TowerItemSO towerSO;
    public TextMeshProUGUI costText;
    public Image towerIcon;

    public void SetItem(TowerItemSO data)
    {
        this.towerSO = data;
        towerIcon.sprite = data.iconTower;
        towerIcon.SetNativeSize();

        costText.text = data.cost.ToString();
    }

    public void BuyTowerOnClicked()
    {
        if (GameManager.Instance.GetCost() >= towerSO.cost)
        {
            GameManager.Instance.Subtract(towerSO.cost);
            Tower tower = Instantiate(towerSO.prefab);

            tower.transform.position = UIManager.Instance.shopUI.GetTileTower().transform.position;
            UIManager.Instance.shopUI.GetTileTower().DestroyTileTower();
            UIManager.Instance.CloseShop();
        }
        else
        {
            Debug.Log("Not enough");
        }
    }
}
