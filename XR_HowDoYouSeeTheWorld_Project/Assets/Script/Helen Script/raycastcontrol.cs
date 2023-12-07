

using UnityEngine;
using OculusSampleFramework;
//using static UnityEditor.Experimental.GraphView.GraphView;

public class raycastcontrol : MonoBehaviour
{
    public OVRInput.Button deactivateButton = OVRInput.Button.One; // Button to deactivate post-processing
    public OVRInput.Button activateButton = OVRInput.Button.Two; // Button to activate post-processing

    // Reference to the post-processing layer or effect you want to control
    public GameObject laser;

    void Update()
    {
        // Deactivate post-processing when the specified button on the left controller is pressed
        if (OVRInput.GetDown(deactivateButton, OVRInput.Controller.LTouch))
        {
            laser.GetComponent<LineRenderer>().enabled = false;
        }

        // Activate post-processing when the specified button on the left controller is pressed
        if (OVRInput.GetDown(activateButton, OVRInput.Controller.LTouch))
        {
            laser.GetComponent<LineRenderer>().enabled = true;
        }
    }
}

