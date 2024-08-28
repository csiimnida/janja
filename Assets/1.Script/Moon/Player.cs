using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int maxHp = 3;
    private int hp = 3;
    private void Awake()
    {
        Time.timeScale = 1;
    }
    public int Hp
    {
        get
        {
            return hp;
        }
        set
        {
            hp = value;
            if (hp <= 0)
            {
                hp = 0;
                Time.timeScale = 0;
            }
            else if (hp > maxHp)
            {
                hp = maxHp;
            }
            HpChange();
        }
    }

    private void HpChange()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.SetActive(false);
        }

        for (int i = 0; i < hp; i++)
        {
            if (i < transform.childCount)
            {
                transform.GetChild(i).gameObject.SetActive(true);
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Enemy"))
        {
            Hp--;
        }
    }
}
