using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveComponent : MonoBehaviour
{
    public float speed = 2f;
    public Path path;
    private List<Vector3> Path = new List<Vector3>();

    public Vector3 startPos;
    public Vector3 endPos;
    public int currentIndex = 0;
    private bool isReached = false;

    private void Update()
    {
        if (isReached == false)
        {
            Movement();
        }
    }
    public void SetPath(Path path)
    {
        this.path = path;
    }
    public void Set(float speed)
    {
        this.speed = speed;
        Path = new List<Vector3>();
        Path = path.GetListPosition();
        transform.position = Path[0];
        startPos = Path[currentIndex];
        endPos = Path[currentIndex + 1];
    }

    private void Movement()
    {
        Vector3 direction = endPos - startPos;
        direction.Normalize();
        transform.position += direction * speed * Time.deltaTime;

        if(Vector3.Distance(transform.position, endPos) <= 0.05f)
        {
            currentIndex += 1;
            if (currentIndex == Path.Count - 1)
            {
                isReached = true;
                return;
            }
            startPos = Path[currentIndex];
            endPos = Path[currentIndex + 1];
        }
    }
}
