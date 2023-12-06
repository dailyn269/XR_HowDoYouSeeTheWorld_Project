using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetObject : MonoBehaviour
{
    private Vector3 initialPosition;
    private Quaternion initialRotation;
    public float resetPointY = -5.0f; // Change this to the desired Y coordinate

    void Start()
    {
        initialPosition = transform.position;
        initialRotation = transform.rotation;
    }

    void Update()
    {
        if (transform.position.y < resetPointY)
        {
            ResetToInitialTransform();
        }
    }

    void ResetToInitialTransform()
    {
        transform.position = initialPosition;
        transform.rotation = initialRotation;
        // You can also reset velocity, angular velocity, etc., if needed
        // For example:
        // GetComponent<Rigidbody>().velocity = Vector3.zero;
        // GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
    }
}

