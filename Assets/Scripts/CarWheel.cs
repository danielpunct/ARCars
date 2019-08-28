using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarWheel : MonoBehaviour
{
    WheelCollider targetWheel;

    Vector3 wheelPosiiton = new Vector3();
    Quaternion wheelRotation = new Quaternion();

    private void Update()
    {
        targetWheel.GetWorldPose(out wheelPosiiton, out wheelRotation);
        transform.position = wheelPosiiton;
        transform.rotation = wheelRotation;
    }
}

