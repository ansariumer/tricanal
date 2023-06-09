using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleBurst : MonoBehaviour
{
    public ParticleSystem collisionParticleSystem;
    public SpriteRenderer sr;
    public bool once = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player") && once)
        {
            var em = collisionParticleSystem.emission;
            var dur = collisionParticleSystem.duration;

            em.enabled = true;
            collisionParticleSystem.Play ();

            once = true;
            Destroy(sr);
            Invoke(nameof(DestroyObj), dur);

        }
    }

    void DestroyObj ()
    {
        Destroy (gameObject);
    }
}
