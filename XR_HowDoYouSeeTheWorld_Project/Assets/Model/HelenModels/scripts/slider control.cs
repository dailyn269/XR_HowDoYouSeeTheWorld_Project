using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class slidercontrol : MonoBehaviour
{
    public GameObject slider;
    public int sliderIndex = 0;
    public GameObject[] items;
   
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void clearview()
    {
        foreach (GameObject item in items)
        {
            item.SetActive(false);
        }
    }
    

    // Update is called once per frame
    void Update()
    {
        sliderIndex = (int)slider.GetComponent<Slider>().value;
        clearview();
        items[sliderIndex].SetActive(true);

            
    }
}
