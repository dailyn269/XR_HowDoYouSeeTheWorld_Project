using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetObject : MonoBehaviour
{
    public Transform originalTransform; // Reference to the original transform values
    public string specifiedTag = "SpecifiedObject"; // Tag of the specified object
    private Rigidbody rb; // Reference to the Rigidbody component

    private void Start()
    {
        // Store the original transform values when the script starts
        originalTransform = transform;

        // Get the Rigidbody component
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the collided object has the specified tag
        if (collision.gameObject.CompareTag(specifiedTag))
        {
            // Disable the Rigidbody temporarily to stop physics interactions
            rb.isKinematic = true;

            // Reset position, scale, and rotation to original values
            transform.position = originalTransform.position;
            transform.localScale = originalTransform.localScale;
            transform.rotation = originalTransform.rotation;

            // Re-enable the Rigidbody
            rb.isKinematic = false;
        }
    }
}
