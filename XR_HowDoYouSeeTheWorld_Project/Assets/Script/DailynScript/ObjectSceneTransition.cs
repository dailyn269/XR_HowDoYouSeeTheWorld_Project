/*
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectSceneTransition : MonoBehaviour
{
    public string sceneName;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
*/

using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class ObjectSceneTransition : MonoBehaviour
{
    public string sceneName;
    public OVRScreenFade screenFade; // Reference to the OVRScreenFade component
    public float fadeOutDelay = 1.0f; // Delay before starting fade-out
    public float fadeInDelay = 0.5f; // Delay before starting fade-in after scene load

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(TransitionWithFade());
        }
    }

    IEnumerator TransitionWithFade()
    {
        if (screenFade != null)
        {
            screenFade.FadeOut(); // Trigger fade-out effect
            yield return new WaitForSeconds(fadeOutDelay);

            // Load the new scene
            SceneManager.LoadScene(sceneName);

            // After loading the new scene, you might want to fade back in
            yield return new WaitForSeconds(fadeInDelay); // Adjust the delay as needed
            screenFade.FadeIn(); // Trigger fade-in effect
        }
        else
        {
            Debug.LogWarning("OVRScreenFade component not found!");
            SceneManager.LoadScene(sceneName); // Load the scene without fading if the component is missing
        }
    }
}
