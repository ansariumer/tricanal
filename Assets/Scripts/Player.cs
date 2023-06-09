using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float _speed = 4.5f;

    [SerializeField]
    private int _score;

    private UIManager _uiManager;



    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 5, 0);
        _uiManager = GameObject.Find("Canvas").GetComponent<UIManager>();

        if (_uiManager == null)
        {
            Debug.LogError("THE UI MANAGER IS NULL.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        CalculateMovement();
        

    }

    void CalculateMovement()
    {
        float horizonatlInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        
        transform.Translate(Vector3.right *horizonatlInput * _speed * Time.deltaTime);
        transform.Translate(Vector3.up * verticalInput * _speed * Time.deltaTime);
        
    }

    public void AddScore(int points)
    {
        _score += points;
        _uiManager.UpdateScore(_score);
    }



}
