using UnityEngine;

public class Gun : MonoBehaviour
{
    public float damage = 50f;
    public float range = 100f; //how far gun bullet can reach 
    public float impactForce = 30f;
    
    public ParticleSystem particle;

    public Camera cam;

    // Update is called once per frame
    void Update()
    {
        if( Input.GetButton("Fire1")) // Fire1 default for left mouse button
        {
            Shot();
        }
    }

    // --------------------------------------------------------------------------------------------------------------------------------------------

    void Shot()
    {
        particle.Play();
        
        RaycastHit hitInfo; // collects informations about shoot
        if(Physics.Raycast(cam.transform.position, cam.transform.forward, out hitInfo, range)) //returns true if we hit
        {
            Debug.Log(hitInfo.transform.name);
            
            Enemy enemy = hitInfo.transform.GetComponent<Enemy>();
            enemy?.TakeDamage(damage);
        }
    }
}