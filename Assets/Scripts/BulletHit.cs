using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BulletHit : MonoBehaviour
{
    public ParticleSystem hitEffect;
    private void OnTriggerEnter(Collider other)
    {
        // Check if the collider is from a bullet game object
        var em = hitEffect.emission;

        if (other.CompareTag("Bullet"))
        {
            Debug.Log("Hit");
            em.enabled = true;
            hitEffect.Play();
            // Instantiate the particle effect at the target's position
            // GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
            // Destroy the particle effect after a certain amount of time
            //Destroy(effect, 1.0f);
            ScoreManager.instance.AddPoint();
            
        }
    }
}