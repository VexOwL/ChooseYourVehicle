using UnityEngine;

public class Boat : Vehicle
{
    [SerializeField] private float _minY = -3.5f;
    private bool _isInWater;

    private void FixedUpdate()
    {
        if (GameManager.Instance.CurrentSelect == 3 && _isInWater)
        {
            Move();
        }
    }

    public override void OnTriggerStay(Collider other)
    {
        _isInWater = true;

        if (transform.position.y < _minY)
            transform.position = new Vector3(transform.position.x, _minY, transform.position.z);
    }

    public void OnTriggerExit(Collider other)
    {
        _isInWater = false;
    }
}