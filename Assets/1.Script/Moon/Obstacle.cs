using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField]private GameObject[] obstacles;
    [SerializeField]float randPosStartX,randPosEndX,Y;
    Vector2 randPos;

    public void ObstacleSpawned()
    {
        randPos = new Vector2(Random.Range(randPosStartX, randPosEndX), Y);
        Instantiate(obstacles[Random.Range(0, obstacles.Length)],randPos,Quaternion.identity);
    }
}
