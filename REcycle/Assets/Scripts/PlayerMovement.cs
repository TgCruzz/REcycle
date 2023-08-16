using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public Path path;
    public GameManager gameManager;
    private int currentSegment;
    private float time, speed;
    private bool isComplete;
    void Start()
    {
        gameObject.transform.position = path.waypoints[0].transform.position;

        if (SceneManager.GetActiveScene().buildIndex == 1)
            speed = 4;

        if (SceneManager.GetActiveScene().buildIndex == 2)
            speed = 2.5f;

        if (SceneManager.GetActiveScene().buildIndex == 3)
            speed = 1.5f;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isComplete)
            Move();
        else if (isComplete)
            gameManager.CheckScore();
    }

    private void Move() 
    {
        time += Time.deltaTime * 1/speed;
        if (time > 1) 
        {
            time = 0;
            currentSegment++;
        }
        transform.position = path.LinearPos(currentSegment, time);

        if (currentSegment >= path.waypoints.Length - 2)
            isComplete = true;
    }
}
