using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Castle : MonoBehaviour
{
    public HealthComponent health;
    public CastleSO castleSO;

    private void Start()
    {
        health.SetHp(castleSO.Hp);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            Enemy enemy = collision.GetComponent<Enemy>();
            health.TakeDamage(enemy.GetDame());
            Destroy(enemy.gameObject);
        }
    }
}

