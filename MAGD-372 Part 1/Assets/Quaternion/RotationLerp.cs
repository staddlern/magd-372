using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationLerp : MonoBehaviour
{
    Vector3 relativePosition;
    Quaternion targetRotation;
    
    public Transform target;
    public float smooth = 0.1F;

    bool rotating = false;

    float rotationTime;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            relativePosition = target.position - transform.position;
            targetRotation = Quaternion.LookRotation(relativePosition);
            rotating = true;
            rotationTime = 0;
        }
        if (rotating)
        {
            rotationTime += Time.deltaTime;
            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, rotationTime);
        }
        if (rotationTime > 1)
        {
            rotating = false;
        }
    }
}
