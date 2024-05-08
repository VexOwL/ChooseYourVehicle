using UnityEngine;

public class Helicopter : Vehicle
{
    [SerializeField] private float _verticalSpeed, _gravityScale;
    [SerializeField] private GameObject _rotor, _tailRotor;

    private void FixedUpdate()
    {
        if (GameManager.Instance.CurrentSelect == 2 && !IsDrown)
        {
            Move();
        }

        _playerRb.AddForce(Vector3.down * _playerRb.drag * _gravityScale, ForceMode.Force);
    }

    public override void Move()
    {
        base.Move();
        float verticalInput = Input.GetAxis("UpDown");

        _rotor.transform.Rotate(Vector3.up * _verticalSpeed * (Mathf.Abs(verticalInput) + Mathf.Abs(_forwardInput)) * Time.fixedDeltaTime);
        _tailRotor.transform.Rotate(Vector3.up * _speed * _horizontalInput * Time.fixedDeltaTime);
        _playerRb.AddRelativeForce(Vector3.up * verticalInput * _verticalSpeed);
    }
}
