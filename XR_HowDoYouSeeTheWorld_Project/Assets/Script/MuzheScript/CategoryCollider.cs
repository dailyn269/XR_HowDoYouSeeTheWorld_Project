using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CategoryCollider : MonoBehaviour
{
    public GameObject managerObj;
    public Material matSel;
    public Material matUnsel;
    public Image panel;

    public int num = 0;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            managerObj.GetComponent<CategoryManager>().SetContext(num);
            panel.GetComponent<MeshRenderer>().materials[0] = matSel;

            Color newColor = new Color(110.0f / 255.0f, 1, 57.0f / 255.0f, 184.0f / 255.0f);
            panel.color = newColor;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            managerObj.GetComponent<CategoryManager>().SetContext(0);
            Color newColor = new Color(202.0f / 255.0f, 1, 57.0f / 255.0f, 80.0f / 255.0f);
            panel.color = newColor;
        }
            

    }
}
