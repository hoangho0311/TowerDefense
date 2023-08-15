using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthComponent : MonoBehaviour
{
    public float HpOrigin;
    public float Hp;
    public UIHpBar HpBar;

    public void SetHp(float hp)
    {
        this.HpOrigin = hp;
        this.Hp = hp;
    }

    public void TakeDamage(float dmg)
    {
        this.Hp -= dmg;
        if (this.Hp <= 0)
        {
            this.Hp = 0;
            Destroy(gameObject);
            return;
        }
        float percent = Hp / HpOrigin;
        HpBar.UpdateHp(percent);
    }

    public bool IsDead()
    {
        return Hp <= 0;
    }
}
