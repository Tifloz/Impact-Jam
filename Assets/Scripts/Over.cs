using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Over : MonoBehaviour
{
    private int objects = 0;

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Object")
        {
            objects++;
            Debug.Log("Collision ! " + objects);
        }
    }
}
