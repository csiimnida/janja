using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DontDE : MonoBehaviour
{
        
    void Awake()
    {
        GameObject a = GameObject.Find("Sound");
        if (a && a != gameObject)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }
}
