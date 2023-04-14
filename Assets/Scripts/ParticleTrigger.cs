using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ParticleTrigger : MonoBehaviour
{
    [SerializeField] private ParticleSystem particleSystem; // reference to the Particle System component

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet")) // check if the collider was hit by a bullet
        {
            Debug.Log("Shot!");
            particleSystem.Play(); // play the particle effect
        }
    }
}