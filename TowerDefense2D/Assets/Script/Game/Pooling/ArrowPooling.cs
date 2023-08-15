using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowPooling : MonoBehaviour
{
    public static ArrowPooling Instance;
    public List<Projectile> arrowPool = new List<Projectile>();
    public Projectile projectilePrefab;

    private void Awake()
    {
        Instance = this;
    }

    //Take out arrow
    public Projectile GetArrow()
    {
        Projectile target = null;

        foreach(Projectile prj in arrowPool)
        {
            if(prj.gameObject.activeSelf == false)
            {
                target = prj;
                break;
            }
        }

        if(target == null)
        {
            target = CreateArrow();
        }

        return target;
    }

    private Projectile CreateArrow()
    {
        Projectile prj = Instantiate(projectilePrefab, transform);
        arrowPool.Add(prj);
        return prj;
    }
}
