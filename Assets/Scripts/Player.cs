using UnityEngine;

public class Player : MonoBehaviour
{
    public Driving driving;

    private void Update()
    {
        float inputY = Input.GetAxis("Vertical");
        float inputX = Input.GetAxis("Horizontal");

        driving.Drive(inputY, inputX);
    }
}
