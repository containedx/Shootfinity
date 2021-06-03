using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public GameObject player;


    void Update()
    {
        transform.LookAt(player.transform);
        transform.position += transform.forward * 1f * Time.deltaTime;
    }
}
