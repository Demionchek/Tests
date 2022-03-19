using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _cubeObj;
    [SerializeField] private PlayerInput _playerInput;
    private float _speed;
    private float _delay;
    private float _maxDisatnce;
    private bool _isSpawning;

    public float Speed
    {
        get { return _speed; }
        set { _speed = value; }
    }
    public float SpawnDelay
    {
        get { return _delay; }
        set { _delay = value; }
    }
    public float MaxDistance
    {
        get { return _maxDisatnce; }
        set { _maxDisatnce = value; }
    }

    private void OnEnable()
    {
        UIManager.MenuClick += StopSpawning;
        UIManager.StartClick += StartSpawning;
    }

    private void OnDisable()
    {
        UIManager.MenuClick -= StopSpawning;
        UIManager.StartClick -= StartSpawning;
    }

    public void StopSpawning()
    {
        StopCoroutine(SpawningCorutine());
        _isSpawning = false;
    }

    public void StartSpawning()
    {
        _speed = _playerInput.Speed;
        _maxDisatnce = _playerInput.MaxDistance;
        _delay = _playerInput.SpawnDelay;
        _isSpawning = true;
        StartCoroutine(SpawningCorutine());
    }

    private IEnumerator SpawningCorutine()
    {
        while (_isSpawning)
        {
            GameObject newCube = Instantiate(_cubeObj, transform.position, Quaternion.identity);
            newCube.GetComponent<Rigidbody>().AddForce(Vector3.forward * _speed, ForceMode.Impulse);
            newCube.GetComponent<TheCubeDestroyer>().GetSpawnerPositionAndMaxDistance(transform.position, _maxDisatnce);
            yield return new WaitForSeconds(_delay);
        }
    }
}
