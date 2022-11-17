using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//INHERITANCE 
public class MultipleAxisRotator : Rotator
{
    
    // As we can see, we have no Update method implementation, and the object still rotates because of its inheritance to Rotator Class.
    public override void TransformRotate()
    {
        transform.Rotate(Vector3.up, Time.deltaTime * rotationSpeed);
    }
}
