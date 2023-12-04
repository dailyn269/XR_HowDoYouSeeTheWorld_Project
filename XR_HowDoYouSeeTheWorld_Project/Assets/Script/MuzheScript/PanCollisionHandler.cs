using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanCollisionHandler : MonoBehaviour
{
    public GameObject heater;
    public GameObject cookingManager;
    public enum State
    {
        StableOff,
        StableOn,
        On,
        Off,
    };

    public State state = State.StableOff;

    private void OnCollisionEnter(Collision collision)
    {
        state = State.On;
        //cookingManager.GetComponent<Cooking>().SetFireState("on");
    }

    private void OnCollisionExit(Collision collision)
    {
        state = State.Off;
        //cookingManager.GetComponent<Cooking>().SetFireState("off");
    }

    private void Update()
    {
        if (state == State.StableOff || state == State.StableOn)
            return;

        Color currentColor = heater.GetComponent<MeshRenderer>().material.color;

        if ((currentColor.r == 0.8f && state == State.On))
        {
            state = State.StableOn;
            cookingManager.GetComponent<Cooking>().SetFireState("on");
            return;
        }

        if ((currentColor.r == 0f && state == State.Off))
        {
            state = State.StableOff;
            cookingManager.GetComponent<Cooking>().SetFireState("off");
            return;
        }

        if (state == State.On)
        {
            currentColor.r = Mathf.Clamp(currentColor.r + 0.005f, 0, 0.8f);
        }
        else
        {
            currentColor.r = Mathf.Clamp(currentColor.r - 0.005f, 0, 0.8f);
        }

        // Update the material's color
        heater.GetComponent<MeshRenderer>().material.color = currentColor;
    }
}
