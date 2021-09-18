using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] enemiesPrefab;
    private float spawnLimitYUp = -5;
    private float spawnLimitYDown = 5;
    private float spawnPosX = 9;

    private float startDelay = 3.0f;
    private float spawnInterval = 5.0f;


    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemy();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnEnemy()
    {
        Invoke("SpawnEnemy", Random.Range(startDelay, spawnInterval));

        int index = Random.Range(0, enemiesPrefab.Length);

        Vector3 spawnPos = new Vector3(spawnPosX, Random.Range(spawnLimitYUp, spawnLimitYDown), 0);

        Instantiate(enemiesPrefab[index], spawnPos, enemiesPrefab[0].transform.rotation);


    }
}
