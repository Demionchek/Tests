using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] InputField _speedInputField;
    [SerializeField] InputField _distanceInputField;
    [SerializeField] InputField _delayInputField;
    private float _speed;
    private float _maxDistance;
    private float _spawnDelay;

    public float Speed { get { return _speed; } }
    public float MaxDistance { get { return _maxDistance; } }
    public float SpawnDelay { get { return _spawnDelay; } }

    public void SpeedInput()
    {
        _speed = float.Parse(_speedInputField.text);
        if(_speed == 0)
        {
            _speed = 2f;
        }
    }

    public void DistanceInput()
    {
        _maxDistance = float.Parse(_distanceInputField.text);
        if (_maxDistance == 0)
        {
            _maxDistance = 5f;
        }
    }

    public void DelayInput()
    {
        _spawnDelay = float.Parse(_delayInputField.text);
        if (_spawnDelay == 0)
        {
            _spawnDelay = 2f;
        }
    }
}
