using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Direction
{
    Horizontal, Vertical
}
public class CameraMove : MonoBehaviour
{
    public Direction direction = Direction.Vertical;
    public Vector3 firstPoint;
    public Vector3 secondPont;
    public float speedMove;
    // Update is called once per frame
    void Update()
    {
        Processing();
    }

    public void Processing()
    {
        if (Input.GetMouseButtonDown(0))
        {
            firstPoint = Input.mousePosition;
        }
        if (Input.GetMouseButton(0))
        {
            secondPont = Input.mousePosition;

            var direction = secondPont - firstPoint;
            direction.Normalize();

            if (this.direction == Direction.Horizontal)
            {
                direction.y = 0;
            }
            else
            {
                direction.x = 0;
            }

            direction.z = 0;
            transform.position += -direction * Time.deltaTime * speedMove;
        }
    }
}
