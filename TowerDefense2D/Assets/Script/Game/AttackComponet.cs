using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EAttack
{
    SingleTarget, MultiTarget,
}

public class AttackComponet : MonoBehaviour
{
    public float Dmg;
    public float Cooldown;
    public float RangeAttack;
    public float SpeedProjectile;
    public EAttack attackType;
    public GameObject Projectile;
    public Transform ShotPos;
    private Transform enemy;
    public ETower towerType;

    private float timeShoot = 0;
    
    public void Setup(float Dmg, float Cooldown, float RangeAttack, float SpeedProjectile, Transform ShotPos, ETower towerType)
    {
        this.Dmg = Dmg;
        this.Cooldown = Cooldown;
        this.RangeAttack = RangeAttack;
        this.ShotPos = ShotPos;
        this.SpeedProjectile = SpeedProjectile;
        this.towerType = towerType;
    }

    private void Update()
    {
        if (enemy == null) return;
        timeShoot += Time.deltaTime;
        if (timeShoot > Cooldown)
        {
            timeShoot = 0;
            SpawnProjectile();
        }
    }

    public void SetTarget(Transform target)
    {
        this.enemy = target;
    }

    private void SpawnProjectile()
    {
        var projectile = ArrowPooling.Instance.GetArrow();
        projectile.gameObject.SetActive(true);
        projectile.transform.position = ShotPos.position;

        int enemyIdentity = enemy.GetComponent<Enemy>().Identity;

        Projectile pjt = projectile.GetComponent<Projectile>();
        pjt.SetIdentity(enemyIdentity);
        pjt.SetTargetPos(enemy.position);
        pjt.SetTowerType(this.towerType);
        pjt.SetDamage(this.Dmg);
        pjt.SetSpeed(this.SpeedProjectile);

        Vector3 direction = (enemy.position - ShotPos.position).normalized;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        projectile.transform.eulerAngles = new Vector3(0, 0, angle);
    }
}
