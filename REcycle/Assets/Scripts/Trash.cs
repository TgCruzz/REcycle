using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Trash : MonoBehaviour
{
    public Material originalMat, hightlightMat;
    public Transform player;
    private float speed = 0.05f;
    private bool isCollected = false;

    private void Start()
    {
        gameObject.GetComponent<Renderer>().material = originalMat;
    }

    private void OnMouseEnter()
    {
        gameObject.GetComponent<Renderer>().material = hightlightMat;
    }

    private void OnMouseExit() 
    {
        gameObject.GetComponent<Renderer>().material = originalMat;
    }

    private void OnMouseDown()
    {
        isCollected = true;
        gameObject.GetComponent<Renderer>().material = originalMat;
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject, 1);
    }

    private void Update()
    {
        MoveToPlayer();
    }

    private void MoveToPlayer() 
    {
        if (isCollected)
        gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, player.transform.position, speed);
    }

}
