using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public float rotationSpeed = .1f;
    public Transform Target, Player;
    float mouseX, mouseY;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Called after update
    void LateUpdate()
    {
        CameraControl();    
    }

    void CameraControl()
    {
        mouseX += Input.GetAxis("Mouse X") * rotationSpeed;
        mouseY += Input.GetAxis("Mouse Y") * rotationSpeed;
        // clamp Y rotation
        mouseY = Mathf.Clamp(mouseY, -35f, 60f);

        transform.LookAt(Target);
        
        if(Input.GetKey(KeyCode.F))
        {
            Target.rotation = Quaternion.Euler(mouseY, mouseX, 0f);
        }
        else
        {
            Target.rotation = Quaternion.Euler(mouseY, mouseX, 0f);
            Player.rotation = Quaternion.Euler(0f, mouseX, 0f);
        }
    }

}
