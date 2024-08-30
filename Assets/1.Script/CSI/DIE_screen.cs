using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DIE_screen : MonoBehaviour
{
    
    
    IEnumerator WaitThreeSeconds()
    {
        yield return new WaitForSecondsRealtime(5);
        
        SceneManager.LoadScene("Start");
    }

    public void Play()
    {
        foreach (var VARIABLE in gameObject.GetComponentsInChildren<AudioSource>())
        {
            VARIABLE.Play();
        }

        
        StartCoroutine(WaitThreeSeconds());
    }
}
