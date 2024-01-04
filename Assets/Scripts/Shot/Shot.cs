using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    [SerializeField] private Bullet _prefab;

    [SerializeField] private float _delay;
    [SerializeField] private float _currentTime = 0f;

    void Update()
    {
        _currentTime += Time.deltaTime;

        if (_currentTime >= _delay)
        {
            Bullet newBullet = Instantiate(_prefab, transform.position, transform.rotation);
            _currentTime = 0f;
        }
    }
}
