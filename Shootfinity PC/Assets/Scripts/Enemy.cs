using System.Collections;
using UnityEngine;


public class Enemy : MonoBehaviour
{
    public float health = 100f;
    

    public void TakeDamage(float damageAmount)
    {
        health -= damageAmount;
        if(health <= 0f)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject, 0.5f);
    }

}