using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShot : MonoBehaviour
{
    [SerializeField] private Bullet _prefab;

    [SerializeField] private float _delay;
    [SerializeField] private float _currentTime = 0f;

    void Update()
    {
        _currentTime += Time.deltaTime;

        if (_currentTime >= _delay)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Bullet newBullet = Instantiate(_prefab, transform.position, transform.rotation);
                _currentTime = 0f;
            }
        }
    }
}
