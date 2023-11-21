using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectSceneTransition : MonoBehaviour
{
    public string sceneToLoad;
    private bool isGrabbed = false;

    void Update()
    {
        CheckForGrabbing();
    }

    void CheckForGrabbing()
    {
        // Check for input from the Oculus controller to simulate grabbing
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger) && isGrabbed)
        {
            LoadNewScene();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("CatDoorKnob"))
        {
            isGrabbed = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("CatDoorKnob"))
        {
            isGrabbed = false;
        }
    }

    void LoadNewScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
