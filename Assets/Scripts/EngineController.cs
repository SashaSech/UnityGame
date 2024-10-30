using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EngineController : MonoBehaviour
{
    [SerializeField] private GameObject Engine;
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) 
            || Input.GetKey(KeyCode.R) || Input.GetKey(KeyCode.F) || Input.GetKey(KeyCode.Q) 
            || Input.GetKey(KeyCode.E) || Input.GetKey(KeyCode.A))
            Engine.SetActive(true);
        else Engine.SetActive(false);
    }
}
