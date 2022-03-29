using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform playerTransform;
    public float ScreenPosition = 6.5f;
    public float ScreenPosition2 = 6.5f;
    private int speed = 2;
    bool movingRight = true;

    void Start()
    {
      
    }

    void Update()
    {
        var Player = GameObject.Find("fågel");
        float playerSpeed = speed * Time.deltaTime;
        Vector3 playerPosition = playerTransform.position;

        if(playerPosition.x >= ScreenPosition)
        {
            movingRight = false;
            Player.transform.localScale = new Vector3(-1f, 1f, 1f);
        }
        if (playerPosition.x <= ScreenPosition2)
        {
            movingRight = true;
            Player.transform.localScale = new Vector3(1f, 1f, 1f);
        }

        if (movingRight)
        {
            Player.transform.position = Player.transform.position + Vector3.right * playerSpeed;
        }
        else if (!movingRight)
        {
            Player.transform.position = Player.transform.position + Vector3.left * playerSpeed;
        }
    }
}
