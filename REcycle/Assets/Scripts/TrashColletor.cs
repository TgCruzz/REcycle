using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashColletor : MonoBehaviour
{
    public int selection;

    private void Start()
    {
        selection = 0;
        SelectCollector();
    }

    private void SelectCollector() 
    {
        int i = 0;
        foreach (Transform collector in transform) 
        {
            if (i == selection) 
                collector.gameObject.SetActive(true);
            else
                collector.gameObject.SetActive(false);
            i++;             
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            selection = 0; //plastic
            SelectCollector();
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            selection = 1; //paper
            SelectCollector();
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            selection = 2; //glass
            SelectCollector();
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            selection = 3; //metal
            SelectCollector();
        }
    }
}
