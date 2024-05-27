using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private Enemy _enemyPrefab;
    [SerializeField] private Target _target;

    public void CreateEnemy()
    {
        Instantiate(_enemyPrefab,transform).Initialize(_target);
    }
}
