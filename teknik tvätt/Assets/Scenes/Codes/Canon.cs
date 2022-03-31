using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canon : MonoBehaviour
{
    public Transform canon;

    public float offset;

    private void Update()
    {
        if (!BrickyCanon.MouseLigal())
        {
            return;
        }

        Vector3 projektileOrigin = canon.position;
        Vector3 mouseWorldePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        mouseWorldePosition.z = projektileOrigin.z;

        Vector3 direction = (mouseWorldePosition - projektileOrigin).normalized;

        Vector3 rot = canon.eulerAngles;
        rot.z = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        rot.z += offset;

        canon.eulerAngles = rot;
    }
}
