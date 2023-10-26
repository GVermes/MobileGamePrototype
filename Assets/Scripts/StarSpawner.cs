using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarSpawner : MonoBehaviour
{
    public GameObject[] stars;

    public float minX;
    public float maxX;
    public float minY;
    public float maxY;

    public GameObject spawnVFX;
    public float durationOfSpawnVFX;

    Vector2 spawnPosition;

    private void Start()
    {
        InvokeRepeating("SpawnStar", 5f, Random.Range(3f, 5f));
    }

    Vector2 GetRandomPosition()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);
        return new Vector2(randomX, randomY);
    }

    public void SpawnStar()
    {
        this.transform.position = GetRandomPosition();
        StartCoroutine("Spawning"); 
    }

    IEnumerator Spawning()
    {
        yield return null;
        GameObject spawn = Instantiate(spawnVFX, transform.position, transform.rotation);
        Destroy(spawn, durationOfSpawnVFX);
        yield return new WaitForSeconds(0.7f);
        Instantiate(stars[Random.Range(0, stars.Length)], transform.position, transform.rotation);
    }
}
