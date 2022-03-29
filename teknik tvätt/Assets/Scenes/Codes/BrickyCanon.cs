using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickyCanon : MonoBehaviour
{
    public LayerMask collisionmask;
    public Transform player;

    public float speed = 200f;
    public float time = 0;
    private bool shoting = false;

    Vector3 direction;
    private float currenttime;

    void Start()
    {
        
    }
    void Update()
    {
        var kanonPivit = GameObject.Find("KanonPivit");


        if (Input.GetMouseButtonDown(0) && !shoting && MouseLigal()) // skjuter iväg brickard när mouseklick händer.
        {
            var projektileOrigin = player.position;
            var mouseWorldePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            mouseWorldePosition.z = projektileOrigin.z;

            direction = (mouseWorldePosition - projektileOrigin).normalized;

            shoting = true;
            currenttime = time;

            var rot = player.eulerAngles;
            rot.z = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            player.eulerAngles = rot;
        }

        if (currenttime > 0f)
        {
            currenttime -= Time.deltaTime;

            if (currenttime < 0f) // när current time = 0 så sätter den shoting till false så att det går att skjuta igen
            {
                currenttime = -1f;
                shoting = false;
                player.position = player.transform.position = new Vector3(-4.29f, -0.63f, 0); // teleporterar brickard till startpunkten
                
                var rot = player.eulerAngles;
                rot.z = 27.72f;
                player.eulerAngles = rot;

            }
        }
        if (shoting) // Skjuter
        {

            player.position += direction * (speed * Time.deltaTime);
          
        }
       

    }
    

    private bool MouseLigal()
    {
        if (Camera.main.ScreenToWorldPoint(Input.mousePosition).x > 9f)
        {
            return false;
        }
        if (Camera.main.ScreenToWorldPoint(Input.mousePosition).x < -3f)
        {
            return false;
        }
        if (Camera.main.ScreenToWorldPoint(Input.mousePosition).y > 5f)
        {
            return false;
        }
        if (Camera.main.ScreenToWorldPoint(Input.mousePosition).y < 0f)
        {
            return false;
        }
        return true;
    }
}

