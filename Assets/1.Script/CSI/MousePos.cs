using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePos : MonoBehaviour
{
    private Camera cam;
    private void Awake()
    {
        cam = Camera.main;

    }


    private void Update()
    {
        
        if (Input.GetMouseButton(0))
        {
            Vector3 mousePosition = Input.mousePosition;
            if (mousePosition.x >= 0 && mousePosition.x <= Screen.width &&
                mousePosition.y >= 0 && mousePosition.y <= Screen.height)
            {
                Vector3 mousePositionInWorld = cam.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, cam.nearClipPlane));
                transform.position = mousePositionInWorld;
            }
        }
    }
}

