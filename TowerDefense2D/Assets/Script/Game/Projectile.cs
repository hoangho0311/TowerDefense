using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float Dmg;
    public int IdentityID;
    public MoveForwardComponent moveForward;
    public ETower towerType;
    public Vector3 targetPos;

    public bool isReached = false;

    public void SetTowerType(ETower tower)
    {
        this.towerType = tower;
    }
    public void SetIdentity(int id)
    {
        this.IdentityID = id;
    }

    public void SetTargetPos(Vector3 pos)
    {
        targetPos = pos;
    }

    private void Update()
    {
        if (isReached) return;
        if(Vector2.Distance(transform.position, targetPos) < 0.05f)
        {
            isReached = true;
            StartCoroutine(WaitingforDestroy());
        }
    }

    public IEnumerator WaitingforDestroy()
    {
        moveForward.Stop();
        yield return new WaitForSeconds(1f);
        gameObject.SetActive(false);
        isReached = false;
    }

    public void SetSpeed(float speed)
    {
        this.moveForward.SetSpeed(speed);
    }
    public void SetDamage(float dmg)
    {
        this.Dmg = dmg;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Enemy enemy = collision.GetComponent<Enemy>();
        if (enemy != null)
        {
            if(towerType == ETower.SingleTarget)
            {
                if (enemy.Identity == this.IdentityID)
                {
                    enemy.TakeDamage(this.Dmg);
                    //gameObject.SetActive(false);
                    isReached = true;
                    StartCoroutine(WaitingforDestroy());
                }
            }
            else
            {
                enemy.TakeDamage(this.Dmg);
                //gameObject.SetActive(false);
                isReached = true;
                StartCoroutine(WaitingforDestroy());
            }

        }
    }
}
