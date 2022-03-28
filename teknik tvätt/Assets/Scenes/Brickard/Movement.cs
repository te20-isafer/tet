using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform playerTransform;
    public float ScreenPosition = 6.5f;

    void Start()
    {
      
    }
    private int velocity = 4;
    private int speed = 2;

    void Update()
    {
        var Player = GameObject.Find("Bricky");
        float playerSpeed = speed * Time.deltaTime;
        Vector3 playerPosition = playerTransform.position;

        bool movingRight = true;
        if(playerPosition.x >= ScreenPosition)
        {
            movingRight = false;
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
