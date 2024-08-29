using System.Collections;
using UnityEngine;

public class Spawnload : MonoBehaviour
{
    private Obstacle _spawn;

    private void Awake()
    {
        _spawn = GetComponent<Obstacle>();
        StartCoroutine(CO_UPDATE());

    }

    IEnumerator CO_UPDATE()
    {
        _spawn.ObstacleSpawned();
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(CO_UPDATE());
    }
}
