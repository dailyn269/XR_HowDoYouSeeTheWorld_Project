using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayPrompt : MonoBehaviour
{
    [SerializeField] private GameObject promptObj;
    // Start is called before the first frame update
    void Start()
    {
        promptObj.active = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            promptObj.active = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            promptObj.active = false;
        }
    }
}
