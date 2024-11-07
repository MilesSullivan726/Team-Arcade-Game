using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    int waveNumber;
    public GameObject smallEnemy;
    private int enemiesLeft;
    public GameObject canvas;
    private int spawnPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //when no enemies remain, increase wave count and spawn new wave
        enemiesLeft = GameObject.FindGameObjectsWithTag("Enemy").Length;
        if (enemiesLeft == 0)
        {
            waveNumber++;
            SpawnWave(waveNumber);
        }
    }

    //spawn the number of enemies of the wave number at a random range
    void SpawnWave(int enemyCount)
    {
        for (int i = 0; i < enemyCount; i++)
        {
            spawnPos = Random.Range(-48, 48);
            
            Instantiate(smallEnemy, new Vector3(spawnPos, transform.position.y, transform.position.z), transform.localRotation, canvas.transform);
        }
    }
}
