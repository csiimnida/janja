using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int maxHp = 3;
    private int hp = 3;
    [SerializeField] Transform enemys;
    public DIE_screen UI;

    Animator animator;
    private void Awake()
    {
        Time.timeScale = 1;
        animator = GetComponent<Animator>();
        UI = GameObject.Find("DIEUI").GetComponent<DIE_screen>();
        UI.gameObject.SetActive(false);
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
            animator.SetInteger("Atom", hp);
            if (hp <= 0)
            {
                hp = 0;
                UI.gameObject.SetActive(true);
                UI.Play();
                Time.timeScale = 0;
            }
            else if (hp > maxHp)
            {
                hp = maxHp;
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Enemy"))
        {
            Hp--;
            for (int i = enemys.childCount - 1; i >= 0; i--)
            {
                Destroy(enemys.GetChild(i).gameObject);
            }
        }
    }
}
