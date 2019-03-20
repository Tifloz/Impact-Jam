using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject player;

    public float speed = 3;

    private Rigidbody _rb;

    // Start is called before the first frame update
    private void Start()
    {
        _rb = player.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");

        var fVelocity = new Vector3(horizontal, vertical, 0) * speed;
        _rb.velocity = fVelocity;
    }
}