using UnityEngine;

public class OnWheels : MonoBehaviour
{
    public bool WheelsOnGround { get; private set; }

    private void OnTriggerEnter(Collider other)
    {
        WheelsOnGround = true;
    }

    private void OnTriggerStay(Collider other)
    {
        WheelsOnGround = true;
    }

    private void OnTriggerExit(Collider other)
    {
        WheelsOnGround = false;
    }
}