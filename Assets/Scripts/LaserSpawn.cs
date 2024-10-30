using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LaserSpawn : MonoBehaviour
{
    [SerializeField] private GameObject LaserSpawnPrefab;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(LaserSpawnPrefab, transform.position, transform.rotation);
        }
    }
}
