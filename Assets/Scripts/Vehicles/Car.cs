using UnityEngine;

public class Car : Vehicle
{
    private bool _isOnGround = true;

    private void FixedUpdate()
    {
        if (GameManager.Instance.CurrentSelect == 1 && !IsDrown && _isOnGround)
        {
            Debug.Log("NotUpsideDown: " + NotUpsideDown());
            
            if(NotUpsideDown())
                Move();
        }
    }

    private void OnCollisionStay(Collision other)
    {
        _isOnGround = true;
    }

    private void OnCollisionExit(Collision other)
    {
        _isOnGround = false;    
    }
}
