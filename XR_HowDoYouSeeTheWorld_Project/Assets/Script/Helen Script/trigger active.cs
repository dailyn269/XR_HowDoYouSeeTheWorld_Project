using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class triggeractive : MonoBehaviour
{
    public GameObject select;
    public GameObject deselect;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        select.SetActive(true);
        deselect.SetActive(false);
    }
}
