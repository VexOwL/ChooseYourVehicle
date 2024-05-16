using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject _hints;
    [SerializeField] private GameObject[] _cameras;
    [SerializeField] private Vector3 _gravityScale;
    public int CurrentSelect {get; private set;}
    public static GameManager Instance;

    private void Awake()
    {
        Instance = this;

        ResetCameras();
    }

    private void Start()
    {
        _cameras[0].gameObject.SetActive(true);

        CurrentSelect = 0;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1))
        {
            ResetCameras();
            SelectCar();

            _hints.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2))
        {
            ResetCameras();
            SelectHelicopter();

            _hints.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3))
        {
            ResetCameras();
            SelectBoat();

            _hints.SetActive(false);
        }

        Physics.gravity = _gravityScale;
    }

    private void SelectCar()
    {
        CurrentSelect = 1;
        
        _cameras[1].gameObject.SetActive(true);
    }

    private void SelectHelicopter()
    {
        CurrentSelect = 2;
        
        _cameras[2].gameObject.SetActive(true);
    }

    private void SelectBoat()
    {
        CurrentSelect = 3;

        _cameras[3].gameObject.SetActive(true);
    }

    private void ResetCameras()
    {
        foreach (var camera in _cameras)
        {
            camera.gameObject.SetActive(false);
        }
    }
}
