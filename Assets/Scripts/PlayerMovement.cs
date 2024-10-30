using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float movementSpeed = 100f;
    [SerializeField] float turnSpeed = 100f;
    [SerializeField] Rigidbody rb;
    private float yaw, pitch, roll;
    //public Transform myTransform;
    private void Update()
    {
        Turn();
        Thrust();
    }
    private void Thrust()
    {
        Vector3 direction = new Vector3();
        if (Input.GetKey(KeyCode.W))
            direction = transform.forward;
        //if (Input.GetAxis("Vertical") > 0)
            // transform.position += transform.forward * movementSpeed * Time.deltaTime * Input.GetAxis("Vertical");
        rb.velocity = direction * movementSpeed * Time.deltaTime;
    }
    private void Turn()
    {
        yaw = turnSpeed * Time.deltaTime * Input.GetAxis("Horizontal");
        pitch = turnSpeed * Time.deltaTime * Input.GetAxis("Pitch");
        roll = turnSpeed * Time.deltaTime * Input.GetAxis("Roll");
        transform.Rotate(pitch, yaw, -roll);
    }
    public void TakeDamage()
    {
        Debug.Log("Damage is taken");
    }
}
