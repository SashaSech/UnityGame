using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class AsteroidManager2 : MonoBehaviour
{
    [SerializeField] [Range(10, 100)] private int asteroidCount = 50;
    [SerializeField] [Range(100f, 500f)] private float radius = 300f;
    [SerializeField] [Range(1f, 5f)] private float maxScale = 5f;
    [SerializeField] private List<GameObject> _asteroidPrefab;

    private Transform _transform;

    private void Awake()
    {
        _transform = transform;
    }

    private void OnEnable()
    {
        SpawnAsteroids();
    }

    private void SpawnAsteroids()
    {
        for (int i = 0; i < asteroidCount; i++)
        {
            GameObject asteroid = Instantiate(_asteroidPrefab[Random.Range(0, _asteroidPrefab.Count)],
                _transform.position, Quaternion.identity);
            float scale = Random.Range(0.5f, maxScale);
            asteroid.transform.localScale = new Vector3(scale, scale, scale);
            asteroid.transform.position += Random.insideUnitSphere * radius;
            asteroid.GetComponent<Rigidbody>()?.AddTorque(Random.insideUnitSphere * Random.Range(0f, 50f));
        }
    }
}
