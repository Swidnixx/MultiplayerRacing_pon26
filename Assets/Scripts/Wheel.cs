using UnityEngine;

public class Wheel : MonoBehaviour
{
    public MeshRenderer model;
    public WheelCollider wh;

    private void Update()
    {
        wh.GetWorldPose(out Vector3 pos, out Quaternion rot);
        model.transform.position = pos;
        model.transform.rotation = rot;
    }
}
