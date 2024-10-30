using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class EnemieController1 : MonoBehaviour
{
    [SerializeField] private Transform player, myTransform;
    [SerializeField] private float speed = 5, distance = 70, rotateSpeed = 5;
    private Rigidbody rb;
    private bool endFollow = false;
    private Vector3 endPosition;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        if (Vector3.Distance(myTransform.position, player.position) < distance)
        {
            endFollow = false;
            myTransform.LookAt(player);
            rb.velocity = myTransform.forward * speed * Time.deltaTime;
        }
        else
        {
            if (!endFollow)
            {
                endFollow = true;
                endPosition = myTransform.position;
            }
            else
            {
                rb.velocity = myTransform.forward * speed * Time.deltaTime;
                myTransform.rotation *= Quaternion.Euler(0, rotateSpeed * Time.deltaTime, 0);
            }
        }
    }
}
