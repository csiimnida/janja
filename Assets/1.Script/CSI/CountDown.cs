using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    private TextMeshProUGUI _textMeshProUGUI;
    private AudioSource _audio;
    public AudioClip CountdownClip;

    private void Awake()
    {
        _textMeshProUGUI = GetComponentInChildren<TextMeshProUGUI>();
        _audio = GetComponent<AudioSource>();
    }
    private float _countdownTime = 5f;

    private void Start()
    {
        _audio.clip = CountdownClip;
        _audio.Play();
        StartCoroutine(StartCountdown());
        Time.timeScale = 0;

    }

    private IEnumerator StartCountdown()
    {
        while (_countdownTime > 0)
        {
            
            _audio.Play();
            _textMeshProUGUI.text = _countdownTime.ToString();
            yield return new WaitForSecondsRealtime(1f);
            _countdownTime--;

        }

        _textMeshProUGUI.text = "";
        gameObject.GetComponentInChildren<Image>().color = new Color(0, 0, 0, 0);

        Time.timeScale = 1;
        StartCoroutine(wait());
    }

    private IEnumerator wait()
    {
        _audio.pitch = 1.4f;
        _audio.Play();
        yield return new WaitForSeconds(1);
        Destroy(gameObject);
    }
}
