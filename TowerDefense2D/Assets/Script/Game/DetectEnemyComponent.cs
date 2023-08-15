using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectEnemyComponent : MonoBehaviour
{
    public AttackComponet attackComponet;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            attackComponet.SetTarget(collision.transform);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            attackComponet.SetTarget(collision.transform);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            attackComponet.SetTarget(null);
        }
    }
}
