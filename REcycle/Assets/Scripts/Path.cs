using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Path : MonoBehaviour
{
    public GameObject[] waypoints;
    // Start is called before the first frame update

    public Vector3 LinearPos(int segment, float speed) 
    {
        Vector3 posA = waypoints[segment].transform.position;
        Vector3 posB = waypoints[segment+1].transform.position;

        return Vector3.Lerp(posA, posB, speed);
    }
}
