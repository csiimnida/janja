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
    [SerializeField]Obstacle obstacle;
    private bool canSpawned = true;
    [SerializeField] float spawnedTime = 1f;
    private float spawned;
    private void Start()
    {
        StartCoroutine(yTrue());
    }
    private void Update()
    {
        nowTime += Time.deltaTime;
        spawned += Time.deltaTime;
        score = Mathf.FloorToInt(nowTime);
        scoreText.text = $"score:{score}";
        if(spawned>spawnedTime)
        {
            spawned = 0;
            obstacle.ObstacleSpawned();
        }
    }
    IEnumerator yTrue()
    {
        yield return new WaitForSeconds(30);
        spawnedTime = Random.Range(0.75f, 1f);
        StartCoroutine(yTrue());
    }
}
