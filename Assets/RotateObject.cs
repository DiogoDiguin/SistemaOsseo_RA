using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float sensitivity = 1f;
    private float rotationY = 0f;
    private float rotationX = 0f;
    private bool isRotating = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isRotating = true;
            Debug.Log("Rotation" + rotationY);
            Debug.Log("Rotation" + rotationX);

        }
        else if (Input.GetMouseButtonUp(0))
        {
            isRotating = false;
            Debug.Log("Rotation" + rotationY);
            Debug.Log("Rotation" + rotationX);
        }

        if (isRotating)
        {
            //Capturar o movimento do mouse;
            float mouseX = Input.GetAxis("Mouse X");
            float mouseY = Input.GetAxis("Mouse Y");
            
            //Calcular a rotação com base na sensibilidade
            rotationX += mouseX * sensitivity;
            rotationY += mouseY * sensitivity;
            
            //aplico a rotação no objeto.
            transform.localRotation = Quaternion.Euler(rotationY, rotationX, 0);
            //transform.Rotate(0,0,0);
        }
    }
}
