using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{

    [Range(50, 500)]
    [SerializeField] float mouseSens;
    [SerializeField] Transform body;
    [SerializeField] float Xrot;
    [SerializeField] float Yrot;

    private void Update()
    {
        float rotX = Input.GetAxisRaw("Mouse X") * mouseSens * Time.deltaTime;
        float rotY = Input.GetAxisRaw("Mouse Y") * mouseSens * Time.deltaTime;

        Xrot -= rotY;
        transform.localRotation = Quaternion.Euler(Xrot, 0f, 0f);

        body.Rotate(Vector3.up * rotX);
    }


}
