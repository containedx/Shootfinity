using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemySpawner : MonoBehaviour
{
    public EnemyMovement enemyPrefab;
    public Transform parent;
    public GameObject player;

    public float spawningSpeed;

    private void Start()
    {
        StartCoroutine(SpawnEnemy(spawningSpeed));
    }

    private IEnumerator SpawnEnemy(float time)
    {
        while (true)
        {
            var position = new Vector3(
                Random.Range(-40, 40),
                1,
                Random.Range(-30, 30)
            );
            var enemy = Instantiate(enemyPrefab, position, Quaternion.identity, parent);
            enemy.player = player;
            Debug.Log("enemy spawned " + enemy.transform.position);
            yield return new WaitForSeconds(time);
        }
    }
}
