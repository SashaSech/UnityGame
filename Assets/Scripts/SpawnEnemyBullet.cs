using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemyBullet: MonoBehaviour
{
    [SerializeField] private Transform playerTarget;
    [SerializeField] private GameObject bullet;
    [SerializeField] private float timeShoot = 5f, distanceToPlayer = 30f;
    private float timeNowShoot = 0;
    

    private void FixedUpdate()
    {
        if (Vector3.Distance(transform.position, playerTarget.position) > distanceToPlayer)
            return;
        timeNowShoot += Time.fixedDeltaTime;
        if (timeNowShoot >= timeShoot)
        {
            var obj = Instantiate(bullet, transform.position, Quaternion.Euler(0, 0, 0));
            obj.GetComponent<EnemyShooting>().player = playerTarget;
            obj.transform.LookAt(playerTarget);
            timeNowShoot = 0;
        }
    }
}
