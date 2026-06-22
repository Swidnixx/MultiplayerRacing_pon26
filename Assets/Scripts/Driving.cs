using UnityEngine;

public class Driving : MonoBehaviour
{
    public Wheel[] frontWheels;
    public Wheel[] rearWheels;

    public float engineForce = 500;
    public float steerAngle = 25;
    public float brakingForce = 25000;

    public Transform centerOfMass;
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        rb.centerOfMass = centerOfMass.localPosition;
    }

    public void Drive(float acceleration, float steer, float brake)
    {
        //Przednie ko³a
        foreach(var wheel in frontWheels)
        {
            wheel.wh.motorTorque = acceleration * engineForce;
            wheel.wh.steerAngle = steer * steerAngle;
            wheel.wh.brakeTorque = brake * brakingForce;
        }

        //Tylne ko³a
        foreach (var wheel in rearWheels)
        {
            wheel.wh.motorTorque = acceleration * engineForce;
            wheel.wh.brakeTorque = brake * brakingForce;
        }
    }
}
