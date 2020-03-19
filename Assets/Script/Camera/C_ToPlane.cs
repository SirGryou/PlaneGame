using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_ToPlane : MonoBehaviour
{
    public Transform pivot;
    public float cameraDistance = 10f;
    public float sensitivity = 10f;
    private float mouseX;
    private float mouseY;

    private void Update()
    {
        if (Input.GetMouseButton (1))
        {
            mouseX += Input.GetAxis("Mouse X") * sensitivity;
            mouseY += Input.GetAxis("Mouse Y") * sensitivity;

            mouseX %= 360;
            mouseY = Mathf.Clamp(mouseY, -90, 90f);
        }

        transform.eulerAngles = new Vector3(-mouseY, mouseX, 0);
        transform.position = pivot.position - transform.forward * cameraDistance;
    }

}
