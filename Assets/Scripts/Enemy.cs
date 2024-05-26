using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float _speed = 0.03f;
    private SpawnPoint _spawnPoint;

    public void Initialize(SpawnPoint spawnPoint)
    {
        _spawnPoint = spawnPoint;
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.position += _spawnPoint.Direction*_speed;
    }
}
