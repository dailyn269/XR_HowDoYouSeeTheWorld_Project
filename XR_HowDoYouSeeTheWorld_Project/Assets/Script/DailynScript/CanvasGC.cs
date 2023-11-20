using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasGC : MonoBehaviour
{
    public Canvas canvasToShow;

    // Start is called before the first frame update
    void Start()
    {
        canvasToShow.enabled = false;
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("CanvasTrigger2"))
        {
            canvasToShow.enabled = true;
        }
    }
}
