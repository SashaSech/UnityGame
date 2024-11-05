using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    [NonSerialized] public Transform player;
    [SerializeField] private float speed = 20f, timeDestroyBullet = 5f;

    private void Awake()
    {
        StartCoroutine(Wait());
        IEnumerator Wait()
        {
            yield return new WaitForSeconds(0.1f);
            transform.LookAt(player);
        }
    }

    private void Update()
    {
        if (player == null)
            return;
        transform.LookAt(player.transform);
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        //transform.position += transform.forward * speed * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.transform == player)
        {
            player.GetComponent<PlayerMovement>().TakeDamage();
            Destroy(gameObject);
        }
    }
}
