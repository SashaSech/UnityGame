using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LaserMove : MonoBehaviour
{
    public float LaserSpeed = 5f;
    private void Update()
    {
        transform.Translate(transform.forward * LaserSpeed * Time.deltaTime);
    }
}
