using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    

    public GameObject[] enemys;
    public GameObject powerup;

    [SerializeField] private float zEnemySpawn = 12.0f;
    [SerializeField] private float xSpawnRange = 16.0f;
    [SerializeField] private float zPowerupRange = 5.0f;
    [SerializeField] private float ySpawn = 0.75f;

    [SerializeField] private float powerupSpawnTime = 5.0f;
    [SerializeField] private float enemySpawnTime = 1.0f;
    [SerializeField] private float startDelay = 1.0f;
    
    SaveGame savedata = new SaveGame();
    public string playername;
    
    // Start is called before the first frame update
    
    void Start()
    {

        InvokeRepeating("SpawnRandomEnemy", startDelay, enemySpawnTime);
        InvokeRepeating("SpawnPowerup", startDelay, powerupSpawnTime);
        
        show();
        
    }

    // Update is called once per frame
    void Update()
    {


       
    }

    void show()
    {
        
        playername = PlayerDataForSession.Instance.PlayerName;
        Debug.Log("Il giocatore " + playername);
        savedata.SaveBestPlayer(playername, 0);
    }

    void SpawnRandomEnemy()
    {
        float randomX = Random.Range(-xSpawnRange, xSpawnRange);
        int randomIndex = Random.Range(0, enemys.Length);

        Vector3 spawnPos = new Vector3(randomX, ySpawn, zEnemySpawn);

        Instantiate(enemys[randomIndex], spawnPos, enemys[randomIndex].gameObject.transform.rotation);
    }

    void SpawnPowerup()
    {
        float randomX = Random.Range(-xSpawnRange, xSpawnRange);
        float randomZ = Random.Range(-zPowerupRange, zPowerupRange);

        Vector3 spawnPos = new Vector3(randomX, ySpawn, randomZ);

        Instantiate(powerup, spawnPos, powerup.gameObject.transform.rotation);
    }

}
