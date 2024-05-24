using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private float _rotationAngle;

    private void Awake()
    {
        transform.rotation = Quaternion.AngleAxis(_rotationAngle,Vector3.up);
    }
}
