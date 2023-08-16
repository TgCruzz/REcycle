using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.XR;

public class PlayerCam : MonoBehaviour
{
    float rotX, rotY, rotSpeed;

    // Start is called before the first frame update
    void Start()
    {
        rotSpeed = 1000f;

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        rotX -= Input.GetAxis("Mouse Y") * Time.deltaTime * rotSpeed;
        rotY += Input.GetAxis("Mouse X") * Time.deltaTime * rotSpeed;
        rotX = Mathf.Clamp(rotX, -90f, 90f);

        transform.rotation = Quaternion.Euler(rotX, rotY, 0);
    }
}
