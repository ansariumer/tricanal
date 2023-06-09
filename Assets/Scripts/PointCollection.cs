using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PointCollection : MonoBehaviour
{

    [SerializeField]
    private Player _player;

    [SerializeField]
    private bool BoxCollider2D = true;

    void Start()
    {
        _player = GameObject.Find("Player").GetComponent<Player>();
        // _player = GameObject.Find("BoxCollider2D").GetComponent<Player>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Point"))
            {
                if (_player != null)
                {
                    _player.AddScore(10);
                    Destroy(other.gameObject);
                }
                
            }
        // Add 20 to score on colliding with yellow 
        if (other.gameObject.CompareTag("Double")) 
        {
            if (_player != null)
            {
                _player.AddScore(20);
                Destroy(other.gameObject);
                
            }
        }  

        if (other.gameObject.CompareTag("Invisibale"))
        {  
            BoxCollider2D = false;   
        }

    }
    

}