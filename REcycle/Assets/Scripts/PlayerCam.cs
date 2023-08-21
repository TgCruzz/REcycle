using UnityEngine;

public class PlayerCam : MonoBehaviour
{
    float rotX, rotY, rotSpeed;
    public Transform direction;

    // Start is called before the first frame update
    void Start()
    {
        rotSpeed = 100f;

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
        direction.rotation = Quaternion.Euler(rotX, rotY, 0);
    }
}
