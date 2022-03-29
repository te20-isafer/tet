using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalonTrigger : MonoBehaviour
{
    public GameObject bulletPrefab;
    public LayerMask collisionmask;
    public SpriteRenderer renderer;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        print(collision.name);

        var bloon = gameObject;
        bool active = false;
        float speed = 20 * Time.deltaTime;
        if (collision.CompareTag("Object") == true)
        {
            print("works");
            active = true;
            Instantiate(bulletPrefab, bloon.transform.position, Quaternion.identity, null);
            this.enabled = false;
            renderer.enabled = false;
        }
    }
}
