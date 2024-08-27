using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private int score;
    private float nowTime;
    [SerializeField]TextMeshProUGUI scoreText;
    private void Update()
    {
        nowTime += Time.deltaTime;
        score = Mathf.FloorToInt(nowTime);
        scoreText.text = $"score:{score.ToString()}";
    }
}
