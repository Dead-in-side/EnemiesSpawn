using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField] private Transform _rotatePoint;

    private float _rotateAngle = 20;

    void Update()
    {
        transform.RotateAround(_rotatePoint.position, Vector3.up, _rotateAngle*Time.deltaTime);    
    }
}
