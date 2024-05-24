using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float _speed = 0.03f;

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        float minAcceleration = 0;
        float maxAcceleration = 2;
        float acceleration = Random.Range(minAcceleration, maxAcceleration);

        Vector3 position = transform.localPosition;
        position.z += _speed * acceleration;

        transform.localPosition = position;
    }
}
