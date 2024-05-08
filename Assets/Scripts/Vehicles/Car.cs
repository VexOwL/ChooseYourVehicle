using UnityEngine;

public class Car : Vehicle
{
    [SerializeField] private OnWheels _onWheels;

    private void FixedUpdate()
    {
        bool _driveAllowed = GameManager.Instance.CurrentSelect == 1 && !IsDrown && _onWheels.WheelsOnGround;
        
        if (_driveAllowed)
        {
            Move();
        }
    }
}
