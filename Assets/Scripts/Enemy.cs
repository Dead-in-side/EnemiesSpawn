using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float _speed = 0.03f;
    private Target _target;

    public void Initialize(Target target)
    {
        _target = target;
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position,_target.transform.position,_speed);
    }
}
