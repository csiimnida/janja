using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class STackInfo : MonoBehaviour
{
    public float Powwer,Size = 1;
    //public 
    private void Update()
    {
        Collider2D[] collider2Ds = Physics2D.OverlapCircleAll(transform.position, Size);
        foreach (var VARIABLE in collider2Ds)
        {
            if(VARIABLE.transform.CompareTag("Wall")) return;
            float J_Power = VARIABLE.GetComponent<junja>().Power;
            Rigidbody2D J_rigidbody2D = VARIABLE.GetComponent<Rigidbody2D>();
            J_rigidbody2D.velocity = Vector3.zero;
            Vector3 pluseminus;
            if (Powwer * J_Power > 0)
            {
                //서로의 부호가 같음
                //== 밀쳐냄
                pluseminus = (VARIABLE.transform.position - transform.position).normalized;

            }
            else
            {
                //서로의 부호가 다름
                //끌어 당김
                pluseminus = (transform.position - VARIABLE.transform.position).normalized;
            }

            J_rigidbody2D.AddForce(pluseminus * (Mathf.Abs(J_Power)+Mathf.Abs(Powwer)),ForceMode2D.Impulse);
        }
    }

    

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position,Size);
    }
}
