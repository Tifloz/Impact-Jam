using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Over : MonoBehaviour
{
    private GameManager _gameManager;

    private void OnTriggerEnter(Collider other)
    {
        _gameManager.Score++;
        Debug.Log(_gameManager.Score);
        Destroy(gameObject);
        if (_gameManager.Score >= 4)
        {
            Debug.Log("END SCREEN");
        }
    }

    private void Start()
    {
        _gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
}