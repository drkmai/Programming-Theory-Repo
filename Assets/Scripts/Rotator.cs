using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    // Starts ENCAPSULATION
    protected float rotationSpeed = 100f;

    public float RotationSpeed {
        get { return rotationSpeed ; }
        set { 
            if (rotationSpeed < 0.0f) {
               Debug.LogError("Rotation Speed can't be negative.");
            }
            rotationSpeed = value;
        }
    }

    // Ends ENCAPSULATION

    // Update is called once per frame
    void Update()
    {
        TransformRotate();
    }

    // Allowing method to be overrided by Child classes.
    // Also, ABSTRACTION
    public virtual void TransformRotate()
    {
        transform.Rotate(0, Time.deltaTime * rotationSpeed, 0, Space.World);
    }
}
