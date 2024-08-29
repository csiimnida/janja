using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSEEn : MonoBehaviour
{
    public void START_BT()
    {
        SceneManager.LoadScene("2.Scenes/Main/Main");
    }
    public void QUIT_BT()
    {
        Application.Quit();
    }
    private void Awake()
    {
        Time.timeScale = 0.5f;
    }
}
    