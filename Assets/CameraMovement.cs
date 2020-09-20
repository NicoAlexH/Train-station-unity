using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float mouseSensitivity;
    public float mouseSmoothing;


    public GameObject Player;
    Vector2 mouseLook;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {      
        Vector2 mousePosition = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));
        mousePosition = Vector2.Scale(mousePosition, new Vector2(mouseSensitivity * mouseSmoothing, mouseSensitivity * mouseSmoothing));

        mouseLook += mousePosition;
        transform.localRotation = Quaternion.AngleAxis(-mouseLook.y, Vector3.right);
        Player.transform.localRotation = Quaternion.AngleAxis(mouseLook.x, Player.transform.up);
    }
}
