/*using UnityEngine;
using OculusSampleFramework;

public class PostProcessingController: MonoBehaviour
{
    public OVRInput.Button buttonToDeactivate = OVRInput.Button.One; // Change to the desired button

    // Reference to the post-processing layer or effect you want to deactivate
    public GameObject postProcessingLayer;

    void Update()
    {
        // Check if the specified button on the left controller is pressed
        if (OVRInput.GetDown(buttonToDeactivate, OVRInput.Controller.LTouch))
        {
            // Deactivate the post-processing layer or effect
            if (postProcessingLayer != null)
            {
                postProcessingLayer.SetActive(false);
                Debug.Log("Post-processing deactivated!");
            }
        }
    }
}
*/

using UnityEngine;
using OculusSampleFramework;

public class PostProcessingController : MonoBehaviour
{
    public OVRInput.Button deactivateButton = OVRInput.Button.One; // Button to deactivate post-processing
    public OVRInput.Button activateButton = OVRInput.Button.Two; // Button to activate post-processing

    // Reference to the post-processing layer or effect you want to control
    public GameObject postProcessingLayer;

    void Update()
    {
        // Deactivate post-processing when the specified button on the left controller is pressed
        if (OVRInput.GetDown(deactivateButton, OVRInput.Controller.LTouch))
        {
            if (postProcessingLayer != null)
            {
                postProcessingLayer.SetActive(false);
                Debug.Log("Post-processing deactivated!");
            }
        }

        // Activate post-processing when the specified button on the left controller is pressed
        if (OVRInput.GetDown(activateButton, OVRInput.Controller.LTouch))
        {
            if (postProcessingLayer != null)
            {
                postProcessingLayer.SetActive(true);
                Debug.Log("Post-processing activated!");
            }
        }
    }
}

