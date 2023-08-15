using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHpBar : MonoBehaviour
{
    public Image HpMain;

    public void UpdateHp(float percent)
    {
        HpMain.fillAmount = percent;
    }
}
