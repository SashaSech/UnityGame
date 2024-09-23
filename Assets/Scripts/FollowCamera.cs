using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private Vector3 defaultDistance = new Vector3(0f, 2f, -10f);
    [SerializeField] private float distanceDamp = 10f;
    [SerializeField] private float rotationalDamp = 10f;
    public Vector3 velocity = Vector3.one;
    Transform myTransform;
    private void Awake()
    {
        myTransform = transform;
    }

    private void LateUpdate()
    {
        Vector3 toPos = target.position + (target.rotation * defaultDistance);
        Vector3 curPos = Vector3.Lerp(myTransform.position, toPos, distanceDamp * Time.deltaTime);
        myTransform.position = curPos;

        Quaternion toRot = Quaternion.LookRotation(target.position - myTransform.position, target.up);
        Quaternion curRot = Quaternion.Slerp(myTransform.rotation, toRot, rotationalDamp * Time.deltaTime);
        myTransform.rotation = curRot;
    }
    //void SmoothFollow()
    //{
    //    Vector3 toPos = target.position + (target.rotation * defaultDistance);
    //    Vector3 curPos = Vector3.SmoothDamp(myTransform.position, toPos, ref velocity, distanceDamp);
    //    myTransform.position = curPos;
    //    myTransform.LookAt(target, target.up);
    //}
}
