using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSky : MonoBehaviour
{
    public float speed;
    public GameObject oderobject;

    private void Start()
    {
        
    }

    private void Update()
    {
        transform.position += new Vector3(0, -speed * Time.deltaTime, 0);
        //transform.position = Vector3.forward * 21;
        if (transform.position.y <= -1440)
        {
            transform.position = Vector3.up * 4292;
            //transform.position = Vector3.up * (oderobject.transform.position.y + 1427);
        }
    }
}
