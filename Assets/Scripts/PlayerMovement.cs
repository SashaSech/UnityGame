using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float movementSpeed = 100f;
    [SerializeField] float turnSpeed = 100f;
    //public Transform myTransform;
    private void Update()
    {
        Turn();
        Thrust();
    }
    private void Thrust()
    {
        if (Input.GetAxis("Vertical") > 0)
        transform.position += transform.forward * movementSpeed * Time.deltaTime * Input.GetAxis("Vertical");
    }
    private void Turn()
    {
        float yaw = turnSpeed * Time.deltaTime * Input.GetAxis("Horizontal");
        float pitch = turnSpeed * Time.deltaTime * Input.GetAxis("Pitch");
        float roll = turnSpeed * Time.deltaTime * Input.GetAxis("Roll");
        transform.Rotate(-pitch, yaw, -roll);
    }
}
