using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDead : MonoBehaviour
{
    [SerializeField]
    private Player movement;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(other.gameObject);
        }
    }

    void OnCollisionEnter (Collision CollisionInfo)
    {
        if (CollisionInfo.collider.tag == "Enemy")
        {
            movement.enabled = false;
        }
    }
    
}
