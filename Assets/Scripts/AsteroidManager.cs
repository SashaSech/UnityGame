using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidManager : MonoBehaviour
{
    [SerializeField] int numberOfAsteroids = 5;
    [SerializeField] Asteroid asteroid;
    [SerializeField] int gridSpacing = 50;

    private void Start()
    {
        PlaceAsteroids();
    }
    private void PlaceAsteroids()
    {
        for (int x = 0; x < numberOfAsteroids; x++)
        {
            for (int y = 0; y < numberOfAsteroids; y++)
            {
                for (int z = 0; z < numberOfAsteroids; z++)
                {
                    InstantiateAsteroid(x, y, z); // i = x;
                }
            }
        }
    }
    private void InstantiateAsteroid(int x, int y, int z)
    {
        Instantiate(asteroid, 
            new Vector3( transform.position.x + (x * gridSpacing) + AsteroidOffset(), 
                         transform.position.y + (y * gridSpacing) + AsteroidOffset(), 
                         transform.position.z + (z * gridSpacing) + AsteroidOffset()), 
            Quaternion.identity, 
            transform);
    }
    private float AsteroidOffset()
    {
        return Random.Range(-gridSpacing / 2f, gridSpacing / 2f);
    }
}
