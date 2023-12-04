using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;


public class Cooking : MonoBehaviour
{

    public Mesh cookedMesh;
    public GameObject fire;
    public enum FoodState
    {
        Raw,
        WellDone,
        Burnt,
        Fire
    };

    public enum FireState
    {
        Off,
        On
    };

    public float timeRaw2Well = 5;
    public float timeWell2Burnt = 6;
    public float Burnt2Fire = 5;

    private float timeRemaining;
    private bool timerRunning = false;

    public GameObject pan;
    public Material burntMat;
    public GameObject steak;
    [SerializeField] private GameObject promptObj;
    private TextMeshPro textMesh;
    public FoodState steakState = FoodState.Raw;
    public FireState fireState = FireState.Off;

    // Start is called before the first frame update
    void Start()
    {
        textMesh = promptObj.GetComponent<TextMeshPro>();
        promptObj.SetActive(false);
        fire.SetActive(false);

    }

    public void SetFireState(string _state)
    {
        if (_state == "off")
        {
            fireState = FireState.Off;
            ResetTimer();
        }
        else if (_state == "on")
        {
            fireState = FireState.On;
            StartTimer();
        }
    }

    // Update is called once per frame
    void Update()
    {
        //textMesh.text = timeRemaining.ToString();
        if (fireState == FireState.On)
        {
            
            if (timerRunning)
            {
                if (timeRemaining > 0)
                {
                    timeRemaining -= Time.deltaTime;
                }
                else
                {
                    // Countdown ends
                    if (steakState == FoodState.Raw)
                    {
                        steak.GetComponent<MeshFilter>().mesh = cookedMesh;
                        steakState = FoodState.WellDone;
                        ResetTimer();
                        timerRunning = true;
                    }
                    else if (steakState == FoodState.WellDone)
                    {
                        MeshRenderer steakMeshRenderer = steak.GetComponent<MeshRenderer>();
                        Material[] materials = steakMeshRenderer.materials;
                        materials[0] = burntMat;
                        steakMeshRenderer.materials = materials;

                        steakState = FoodState.Burnt;
                        ResetTimer();
                        timerRunning = true;
                    }
                    else if (steakState == FoodState.Burnt)
                    {
                        ResetTimer();
                        timerRunning = true;
                        steakState = FoodState.Fire;
                    }
                    else
                    {
                        fire.SetActive(true);
                        StopTimer();
                    }
                }
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            promptObj.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            promptObj.SetActive(false);
        }
    }

    public void StartTimer()
    {
        if (!timerRunning)
        {
            timerRunning = true;
            if (steakState == FoodState.Raw)
            {
                timeRemaining = timeRaw2Well;
            }
            else if (steakState == FoodState.WellDone)
            {
                timeRemaining = timeWell2Burnt;
            }
            else if (steakState == FoodState.Burnt)
            {
                timeRemaining = Burnt2Fire;
            }
        }
    }

    public void StopTimer()
    {
        timerRunning = false;
    }

    public void ResetTimer()
    {
        if (steakState == FoodState.Raw)
        {
            timeRemaining = timeRaw2Well;
        }
        else if (steakState == FoodState.WellDone)
        {
            timeRemaining = timeWell2Burnt;
        }
        else if (steakState == FoodState.Burnt)
        {
            timeRemaining = Burnt2Fire;
        }
        timerRunning = false;
    }

    public float GetTimeRemaining()
    {
        return timeRemaining;
    }
}
