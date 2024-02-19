using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceCamera : MonoBehaviour
{
    private Camera mainCamera;

    void Start()
    {
        // Find the main camera in the scene
        mainCamera = Camera.main;
    }

    void Update()
    {
        // Calculate the direction from the character to the camera
        Vector3 lookDirection = mainCamera.transform.position - transform.position;

        // Ensure the sprite faces the camera without rotating in the Z-axis
        Quaternion rotation = Quaternion.LookRotation(lookDirection, Vector3.up);

        // Apply the rotation to the sprite
        transform.rotation = rotation;
    }
}