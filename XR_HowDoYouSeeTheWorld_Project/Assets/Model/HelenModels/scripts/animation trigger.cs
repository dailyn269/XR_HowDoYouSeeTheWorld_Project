using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationtrigger : MonoBehaviour
{
    public GameObject eyeball;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = eyeball.GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        anim.SetTrigger("glaucoma");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
