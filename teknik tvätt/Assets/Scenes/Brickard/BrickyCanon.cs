using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickyCanon : MonoBehaviour
{
    private float speed = 0.01f;
    private bool shoting = false;
    Vector3 mousePosition;



    void Start()
    {
        
    }
    void Update()
    {
        // speed *= Time.deltaTime; 
        var Player = GameObject.Find("bricky");
        if (Input.GetMouseButtonDown(0))
        {
            
            mousePosition = GetMouseDirection.GetMouseWorldPosition(Player.transform.position.z);
            shoting = true;
           
        }

        if (shoting)
        {

            Player.transform.position = Player.transform.position + mousePosition * speed;
            shoting = false;
        }
    }
}
public class GetMouseDirection : MonoBehaviour
{
   
    public static Vector3 GetMouseWorldPosition(float z)
    {
        Vector3 vec = GetMouseWorldPositionWithZ(Input.mousePosition, Camera.main);
        vec.z = z;
        return vec;
    }

    public static Vector3 GetMouseWorldPositionWithZ()
    {
        return GetMouseWorldPositionWithZ(Input.mousePosition, Camera.main);
    }

    public static Vector3 GetMouseWorldPositionWithZ(Camera worldCamera)
    {
        return GetMouseWorldPositionWithZ(Input.mousePosition, worldCamera);
    }

    public static Vector3 GetMouseWorldPositionWithZ(Vector3 screenPosition, Camera worldCamera)
    {
        Vector3 worldPosition = worldCamera.ScreenToWorldPoint(screenPosition);
        return worldPosition;
    }

    public static Vector3 GetDirToMouse(Vector3 fromPosition)
    {
        Vector3 mouseWorldPosition = GetMouseWorldPosition(0f);
        return (mouseWorldPosition - fromPosition).normalized;
    }
}
