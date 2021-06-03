using System.Collections;
using UnityEngine;


public class Enemy : MonoBehaviour
{
    public float health = 100f;

    public ParticleSystem particle;
    public GameObject body;

    public AudioSource audio;
    
    public ScoreController scoreController;
    public GameObject player;

    private bool dead = false;

    void Update()
    {
        MoveTowardsPlayer();
    }
    
    // ----------------------------------------------------------------------------------------------------------------------------------------

    private void MoveTowardsPlayer()
    {
        transform.LookAt(player.transform);
        transform.position += transform.forward * 1f * Time.deltaTime;
    }

    public void TakeDamage(float damageAmount)
    {
        health -= damageAmount;
        if(health <= 0f)
        {
            Die();
        }
    }

    private void Die()
    {
        if (dead) return;

        dead = true;
        scoreController.UpdateScore();
        audio.Play();
        particle.Play();
        Destroy(body);
        Destroy(gameObject, 1.5f);
    }

}