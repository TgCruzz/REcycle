using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Trash : MonoBehaviour
{
    public Transform player;
    private float speed = 0.05f;
    private bool isCollected = false;

    private void Start()
    {

    }

    private void OnMouseDown()
    {
        isCollected = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject, 1);
    }

    private void Update()
    {
        gameObject.transform.RotateAround(transform.position, Vector3.up, 100 * Time.deltaTime);
        MoveToPlayer();
    }

    private void MoveToPlayer() 
    {
        if (isCollected)
        gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, player.transform.position, speed);
    }

}
