using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Antielectron : MonoBehaviour
{
    Rigidbody2D otherObject;
    public float gravitationalConstant = 1f;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        otherObject = GameObject.Find("Atom").GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if(!otherObject) return;
        Vector3 direction = otherObject.position - rb.position;
        float distance = direction.magnitude;
        float forceMagnitude = gravitationalConstant * (rb.mass * otherObject.mass) / Mathf.Pow(distance, 2);
        Vector3 force = direction.normalized * forceMagnitude;

        rb.AddForce(force);
    }
}
