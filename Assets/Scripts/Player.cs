using UnityEngine;

public class Player : MonoBehaviour
{
    public Driving driving;

    private void Update()
    {
        float inputY = Input.GetAxis("Vertical");
        float inputX = Input.GetAxis("Horizontal");
        float brakeInput = Input.GetAxis("Jump");
        Debug.Log(brakeInput);

        driving.Drive(inputY, inputX, brakeInput);
    }
}
