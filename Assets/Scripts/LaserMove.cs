using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LaserMove : MonoBehaviour
{
    public float LaserSpeed = 5f;
    private void FixedUpdate()
    {
        //transform.Translate(transform.up * LaserSpeed);
        transform.localPosition += transform.up * LaserSpeed;
    }
}
