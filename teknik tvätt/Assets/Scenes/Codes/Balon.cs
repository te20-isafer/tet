using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balon : MonoBehaviour
{
    public LayerMask collisionmask;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        var bloon = GameObject.Find("Balon");
        bool active = false;
        if (collision.CompareTag("Object") == true)
        {
            print("works");
            active = true;

        }
        if (active == true)
        {


        }

    }
}
