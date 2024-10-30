using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LaserMove : MonoBehaviour
{
    public float LaserSpeed = 5f;
    [SerializeField] float timer = 1.5f;
    private void FixedUpdate()
    {
        //transform.Translate(transform.up * LaserSpeed);
        transform.localPosition += transform.up * LaserSpeed;
    }
    private void Awake()
    {
        Destroy(gameObject, timer);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Asteroid"))
        {
            Destroy(collision.gameObject);
            //Destroy(gameObject);
        }
    }
}
