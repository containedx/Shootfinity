using System.Collections;
using UnityEngine;


public class Enemy : MonoBehaviour
{
    public float health = 100f;

    public ParticleSystem particle;
    public GameObject body;

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
        particle.Play();
        Destroy(body);
        Destroy(gameObject, 1.5f);
    }

}