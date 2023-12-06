using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class handlecontrol : MonoBehaviour
{

    // Start is called before the first frame update
    public GameObject[] turnon;
    public GameObject[] turnoff;
    public GameObject[] turnoffwhenleave;
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        foreach (GameObject x in turnoff)
        {
            x.SetActive(false);
        }
        foreach (GameObject y in turnon)
        {
            y.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        foreach (GameObject y in turnoffwhenleave)
        {
            y.SetActive(false);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
