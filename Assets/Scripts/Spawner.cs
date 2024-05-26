using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemyPrefab;
    [SerializeField] private List<SpawnPoint> _spawnPoints;

    private float _delay = 2.0f;
    private Coroutine _coroutine;

    private void Start()
    {
        _coroutine = StartCoroutine(CreateCoroutine());
    }

    private IEnumerator CreateCoroutine()
    {
        bool isWork = true;

        WaitForSecondsRealtime delay = new WaitForSecondsRealtime(_delay);

        while(isWork)
        {
            yield return delay ;

            CreateEnemy();
        }
    }

    private void CreateEnemy()
    {
        SpawnPoint spawnPoint = _spawnPoints[Random.Range(0, _spawnPoints.Count)];

        Instantiate(_enemyPrefab, spawnPoint.transform).Initialize(spawnPoint);
    }
}
