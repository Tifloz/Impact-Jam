using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Over : MonoBehaviour
{
    private int objects = 0;
    private void OnTriggerEnter(Collider other)
    {
        objects++;
        Debug.Log(objects);
    }
}
