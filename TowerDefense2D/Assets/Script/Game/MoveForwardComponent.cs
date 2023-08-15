using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForwardComponent : MonoBehaviour
{
    public float speed;
    public float timeDestroy;
    public float timeDestroyCurrent = 0;
    public bool isStopped = false;

    public void SetSpeed(float speed)
    {
        this.speed = speed;
        timeDestroyCurrent = 0;
        isStopped = false;
    }
    private void Update()
    {
        if (isStopped) return;
        timeDestroyCurrent += Time.deltaTime;
        if (timeDestroyCurrent >= timeDestroy)
        {
            gameObject.SetActive(false);
            return;
        }
        transform.position += transform.right * speed * Time.deltaTime;

    }

    public void Stop()
    {
        isStopped = true;
    }
}
