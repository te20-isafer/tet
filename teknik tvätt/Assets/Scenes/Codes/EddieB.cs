using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EddieB : MonoBehaviour
{
    public static EddieB instance;

    public int numberOfHits = 3;
    public float timeToReset = 2f;
    public Vector2 minMaxPosition;
    public SpriteRenderer spriteRenderer;

    public Sprite cleanSprite;
    public Sprite dirtySprite;

    private int currentHealth;

    private float timer;

    private void Start()
    {
        instance = this;
        currentHealth = numberOfHits;
        timer = -1f;

        MakeDirty();
    }

    private void Update()
    {
        if (timer > 0f)
        {
            timer -= Time.deltaTime;

            if (timer <= 0f)
            {
                MakeDirty();
            }
        }
    }

  

    private void Clean()
    {
        print("Eddie is clean!");
        spriteRenderer.sprite = cleanSprite;
        timer = timeToReset;
        Score.instance.AddScore(100);
    }

    public void Hit(GameObject bullet)
    {
        Score.instance.AddScore(10);
        Destroy(bullet);
        currentHealth--;
        if (currentHealth == 0)
        {
            Clean();
        }
    }

    private void Move()
    {
        Vector3 position = transform.position;
        position.x = Mathf.Lerp(minMaxPosition.x, minMaxPosition.y, Random.value);
        transform.position = position;
    }

    private void MakeDirty()
    {
        Move();
        currentHealth = numberOfHits;
        spriteRenderer.sprite = dirtySprite;
    }
}
