using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CataractsCanvasDisplay : MonoBehaviour
{
    public Canvas canvasToShow; // Reference to the Canvas you want to display
    public float displayDuration = 10f; // Duration to display the canvas

    bool canvasDisplayed = false; // Flag to track if canvas has been displayed

    // Start is called before the first frame update
    void Start()
    {
        canvasToShow.enabled = false; // Hide the canvas at the start
    }

    // OnTriggerEnter is called when another collider enters the trigger zone
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("CanvasTrigger") && !canvasDisplayed)
        {
            canvasToShow.enabled = true; // Enable the canvas when triggered by the collider
            StartCoroutine(DisableCanvasAfterDuration());
            canvasDisplayed = true; // Set flag to true when canvas is displayed
        }
    }

    IEnumerator DisableCanvasAfterDuration()
    {
        yield return new WaitForSeconds(displayDuration);

        // Disable the canvas after the specified duration
        canvasToShow.enabled = false;
    }
}
