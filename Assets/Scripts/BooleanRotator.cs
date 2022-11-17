using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//INHERITANCE 
public class BooleanRotator : Rotator
{
    public bool CanRotate = false;
    
    //POLYMORPISM
    void Update()
    {
        if (CanRotate)
        {
            base.TransformRotate();
        }
    }
}
