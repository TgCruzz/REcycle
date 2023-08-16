using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Path path;
    private int currentSegment;
    private float speed;
    private bool isComplete;
    void Start()
    {
        gameObject.transform.position = path.waypoints[0].transform.position;                
    }

    // Update is called once per frame
    void Update()
    {
        if (!isComplete)
            Move();
    }

    private void Move() 
    {
        speed += Time.deltaTime;
        if (speed > 1) 
        {
            speed = 0;
            currentSegment++;
        }
        transform.position = path.LinearPos(currentSegment, speed);

        if (currentSegment >= path.waypoints.Length - 2)
            isComplete = true;
    }
}
