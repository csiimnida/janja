using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DIE_screen : MonoBehaviour
{
    
    
    IEnumerator WaitThreeSeconds()
    {
        yield return new WaitForSecondsRealtime(3);
        
        SceneManager.LoadScene("Start");
    }

    public void Play()
    {
        StartCoroutine(WaitThreeSeconds());
    }
}
