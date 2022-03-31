using UnityEngine;

public class BalonBullet : MonoBehaviour
{

    private void Update()
    {
        if (transform.position.y < -7f)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("EddieB") == true)
        {
            EddieB.instance.Hit(gameObject);
        }
    }
}
