using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarEngine : MonoBehaviour
{
    public WheelCollider wheelL;
    public WheelCollider wheelR;
    public void Accelerate()
    {
        wheelL.motorTorque = 100;
        wheelR.motorTorque = 100;
    }

    public void SteerRight()
    {
        wheelL.steerAngle = 30;
        wheelR.steerAngle = 30;
    }

    public void SteerLeft()
    {
        wheelL.steerAngle = -30;
        wheelR.steerAngle = -30;
    }
}
