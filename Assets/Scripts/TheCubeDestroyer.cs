using UnityEngine;

public class TheCubeDestroyer : MonoBehaviour
{
    private Vector3 _spawnerPos;
    private float _maxDistance;

    public void GetSpawnerPositionAndMaxDistance(Vector3 spawnerPosition, float maxDistance)
    {
        _spawnerPos = spawnerPosition;
        _maxDistance = maxDistance;
    }

    void Update()
    {
        if (Vector3.Distance(transform.position, _spawnerPos) > _maxDistance)
        {
            Destroy(gameObject);
        }
    }
}
