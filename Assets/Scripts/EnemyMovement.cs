using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float movementSpeed = 25f;
    [SerializeField] float rotationalDamp = 1.25f;

    [SerializeField] float detectionDistance = 20f;
    [SerializeField] float rayCastOffset = 2.5f;

    private void Update()
    {
        PathFinding();
        //Turn();
        Move();
    }
    private void Move()
    {
        transform.position += transform.forward * Time.deltaTime * movementSpeed;
    }
    private void Turn()
    {
        Vector3 pos = target.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(pos);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, rotationalDamp * Time.deltaTime);
    }
    private void PathFinding()
    {
        RaycastHit hit;
        Vector3 raycastOffset = Vector3.zero;

        Vector3 left = transform.position - transform.right * rayCastOffset;
        Vector3 right = transform.position + transform.right * rayCastOffset;

        Debug.DrawRay(left, transform.forward * detectionDistance, Color.cyan);
        Debug.DrawRay(right, transform.forward * detectionDistance, Color.cyan);
        if (Physics.Raycast(left, transform.forward, out hit, detectionDistance))
        {
            raycastOffset += Vector3.right;
        }
        else if (Physics.Raycast(right, transform.forward, out hit, detectionDistance))
        {
            raycastOffset -= Vector3.right;
        }
        if (raycastOffset != Vector3.zero)
        {
            transform.Rotate(raycastOffset * 5f * Time.deltaTime);
        }
        else
        {
            Turn();
        }
    }
}
