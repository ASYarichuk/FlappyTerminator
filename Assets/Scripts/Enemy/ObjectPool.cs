using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [SerializeField] private Transform _container;
    [SerializeField] private Zone _prefab;

    private Queue<Zone> _pool;

    public IEnumerable<Zone> PooledObjects => _pool;

    private void Awake()
    {
        _pool = new Queue<Zone>();
    }

    public Zone GetObject()
    {
        if (_pool.Count == 0)
        {
            var zone = Instantiate(_prefab);
            zone.transform.parent = _container;

            return zone;
        }

        return _pool.Dequeue();
    }

    public void PutObject(Zone zone)
    {
        _pool.Enqueue(zone);
        zone.gameObject.SetActive(false);
    }

    public void Reset()
    {
        _pool.Clear();
    }
}
