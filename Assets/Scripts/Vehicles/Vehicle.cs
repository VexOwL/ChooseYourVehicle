using System;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    [SerializeField] private Transform _start;
    [NonSerialized] public bool IsDrown = false;
    [NonSerialized] public float _horizontalInput, _forwardInput;
    [NonSerialized] public Rigidbody _playerRb;
    public float _speed, _turnSpeed;
    private const string _waterTag = "Water";

    private void Start()
    {
        _playerRb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            ResetPosition(_start.position);
        }
    }

    public virtual void Move()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
        _forwardInput = Input.GetAxis("Vertical");

        _playerRb.AddRelativeForce(Vector3.forward * _forwardInput * _speed);
        transform.Rotate(Vector3.up * Time.deltaTime * _turnSpeed * _horizontalInput);
    }

    virtual public void ResetPosition(Vector3 defaultPosition)
    {
        transform.position = defaultPosition;
        transform.eulerAngles = new Vector3(0, 0, 0);

        IsDrown = false;
    }

    virtual public void OnTriggerStay(Collider other)
    {
        if(other.gameObject.CompareTag(_waterTag))
        {
            IsDrown = true;
        }
    }
}