using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalonTrigger : MonoBehaviour
{
    public GameObject bulletPrefab;
    public LayerMask collisionmask;
    public SpriteRenderer renderer;
    public float timeToReset = 2f;

    private float timer;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        print(collision.name);

        var bloon = gameObject;
        bool active = false;
        float speed = 20 * Time.deltaTime;
        if (collision.CompareTag("Object") == true)
        {
            //print("works");
            active = true;
            Instantiate(bulletPrefab, bloon.transform.position, Quaternion.identity, null);
            renderer.enabled = false;
            timer = timeToReset;
        }
    }

    private void Update()
    {
        if (timer > 0f)
        {
            timer -= Time.deltaTime;

            if (timer <= 0f)
            {
                renderer.enabled = true;
            }
        }
    }
}
