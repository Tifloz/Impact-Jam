using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject player;

    public float speed = 3;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        var move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        player.transform.position += move * speed * Time.deltaTime;
    }
}