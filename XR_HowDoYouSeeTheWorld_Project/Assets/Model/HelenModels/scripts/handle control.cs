using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class handlecontrol : MonoBehaviour
{

    // Start is called before the first frame update
    public GameObject[] turnon;
    public GameObject[] turnoff;
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
    // Update is called once per frame
    void Update()
    {
        
    }
}
