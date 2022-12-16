using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Mouselook : MonoBehaviour
{

    public float mouseSensitivity = 100f;
    public Transform playerBody;
    float xrotation = 0f;


    // Update is called once per frame
    void Update()
    {
        // getting input of mouse in X and Y
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
        // rotate in up down direction and lock in 90f direction
        xrotation -= mouseY;
        xrotation = Mathf.Clamp(xrotation, -90f, 90f);
        // look around
       transform.localRotation = Quaternion.Euler(xrotation, 0f, 0f);
       playerBody.Rotate(Vector3.up * mouseX);

    }
}
