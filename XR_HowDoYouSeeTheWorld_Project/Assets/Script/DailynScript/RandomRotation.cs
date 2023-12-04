using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotation: MonoBehaviour
{
    public float rotationSpeed = 50.0f;

    void Update()
    {
        // Generate random rotation amounts for each axis
        float xRot = Random.Range(0.0f, 1.0f) * rotationSpeed * Time.deltaTime;
        float yRot = Random.Range(0.0f, 1.0f) * rotationSpeed * Time.deltaTime;
        float zRot = Random.Range(0.0f, 1.0f) * rotationSpeed * Time.deltaTime;

        // Apply rotation to the object
        transform.Rotate(new Vector3(xRot, yRot, zRot));
    }
}
