using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] private GameObject _player;

    void LateUpdate()
    {
        transform.position = _player.transform.position;
        transform.eulerAngles = new Vector3(0, _player.transform.eulerAngles.y, 0);
    }
}