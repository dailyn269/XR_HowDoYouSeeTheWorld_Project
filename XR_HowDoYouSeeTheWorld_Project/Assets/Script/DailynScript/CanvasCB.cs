using UnityEngine;

public class CanvasCB : MonoBehaviour
{
    public Canvas canvasToShow; // Reference to the Canvas you want to display

    // Start is called before the first frame update
    void Start()
    {
        canvasToShow.enabled = false; // Hide the canvas at the start
    }

    // OnTriggerEnter is called when another collider enters the trigger zone
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("CanvasTrigger3")) // Check if the collider is the player (or a specific tag)
        {
            canvasToShow.enabled = true; // Enable the canvas when triggered by the collider
            Debug.Log("Collider triggered!");
        }
    }
}
