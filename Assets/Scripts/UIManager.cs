using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private Text _scoerText;

    void Start ()
    {
        _scoerText.text = "Score :" + 0;
    }

    public void UpdateScore(int playerScore)
    {
        _scoerText.text = "Score: " + playerScore.ToString();
    }
    // [SerializeField]
    // private Text _gameOverText;

    // private Player movement;

    // private bool Playermovement = true;

    // // Start is called before the first frame update
    // void Start()
    // {
    //     _gameOverText.gameObject.SetActive(false);
    // }

    // // Update is called once per frame
    // void Update()
    // {
        
    // }

    // public void OnCollisionEnter (Collision CollisionInfo)
    // {
    //     if (movement.enabled = false)
    //     {
    //         _gameOverText.gameObject.SetActive(true);
    //     }
    // }
}
