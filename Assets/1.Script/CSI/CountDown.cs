using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

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
        StartCoroutine(StartCountdown());
        _audio.clip = CountdownClip;
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

        _textMeshProUGUI.text = "Countdown Finished";
        Time.timeScale = 1;
        Destroy(gameObject);
    }
}
