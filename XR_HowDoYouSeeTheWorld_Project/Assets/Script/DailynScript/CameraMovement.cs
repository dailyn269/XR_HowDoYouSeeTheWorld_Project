using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float moveSpeed = 1.0f;
    public Transform cameraTransform; // Reference to the OVRCameraRig or camera transform

    void Update()
    {
        // Get thumbstick input from the right controller
        Vector2 thumbstickInput = OVRInput.Get(OVRInput.Axis2D.SecondaryThumbstick);

        // Apply thumbstick input to move the camera
        Vector3 moveDirection = new Vector3(thumbstickInput.x, 0.0f, thumbstickInput.y);
        moveDirection *= moveSpeed * Time.deltaTime;

        // Apply the movement to the camera's position
        cameraTransform.position += cameraTransform.TransformDirection(moveDirection);
    }
}
