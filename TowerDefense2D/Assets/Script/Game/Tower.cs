using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ETower
{
    SingleTarget, MultiTarget,
}

public class Tower : MonoBehaviour
{
    public TowerSO towerSO;
    public Transform ShotPos;

    public AttackComponet attackComponet;

    private void Start()
    {
        attackComponet.Setup(towerSO.Dmg, towerSO.Cooldown, towerSO.RangeAttack, towerSO.SpeedProjectile, ShotPos.parent, this.towerSO.TowerType);
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(ShotPos.position, towerSO.RangeAttack);
    }
}
