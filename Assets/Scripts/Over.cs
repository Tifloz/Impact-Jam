﻿using System.Collections;
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
    }

    private void Start()
    {
        _gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
}