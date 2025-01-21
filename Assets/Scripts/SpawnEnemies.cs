using System.Collections;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    [SerializeField] private GameObject[] _spawners;
    [SerializeField] private GameObject _prefab;
    [SerializeField,Range(0,100)] private float _spawnTime;

    private void Start()
    {
        StartCoroutine(spawnerCourutine());
    }
    private IEnumerator spawnerCourutine()
    {
        while (true)
        {
            Spawn();
            yield return new WaitForSeconds(_spawnTime);
        }
    }

    private void Spawn()
    {
        Instantiate(_prefab, _spawners[Random.Range(0, _spawners.Length)].transform.position,Quaternion.identity);

    }
}
