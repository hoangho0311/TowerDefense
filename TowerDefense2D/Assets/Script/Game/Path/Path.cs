using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path : MonoBehaviour
{
    public List<Transform> listPositions;
    public List<Vector3> GetListPosition()
    {
        List<Vector3> position = new List<Vector3>();
        for(int i = 0; i < listPositions.Count; i++)
        {
            position.Add(listPositions[i].position);
        }
        return position;
    }

    private void OnDrawGizmos()
    {
        for(int i = 0; i < listPositions.Count - 1; i++)
        {
            Gizmos.DrawLine(listPositions[i].position, listPositions[i + 1].position);
        }
    }
}
