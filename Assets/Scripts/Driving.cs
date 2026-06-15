using UnityEngine;

public class Driving : MonoBehaviour
{
    public Wheel[] wheels;

    public float engineForce = 500;
    public float steerAngle = 25;

    public void Drive(float acceleration, float steer)
    {
        foreach(var wheel in wheels)
        {
            wheel.wh.motorTorque = acceleration * engineForce;
            wheel.wh.steerAngle = steer * steerAngle;
        }
    }
}
