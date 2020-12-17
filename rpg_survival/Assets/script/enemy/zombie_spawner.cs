using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombie_spawner : MonoBehaviour
{   
    public GameObject[] zombie;
    public GameObject[] spawnPoints;
    public GameObject player;

    public float distance = 2f;
    public float spawn_timer = 2f;
    private float clock;

    private int randSpawn;
    private int randZombie;

    void Start()
    {
        player = GameObject.Find("player");

    }

   
    void Update()
    {
        clock = clock + Time.deltaTime;

        if(clock>spawn_timer){
            randSpawn = Random.Range(0,spawnPoints.Length);
            randZombie = Random.Range(0,zombie.Length);
            if(distance <= Mathf.Sqrt((spawnPoints[randSpawn].transform.position.x - player.transform.position.x)*(spawnPoints[randSpawn].transform.position.x - player.transform.position.x)  + (spawnPoints[randSpawn].transform.position.y - player.transform.position.y)*(spawnPoints[randSpawn].transform.position.y - player.transform.position.y))){
                Instantiate(zombie[randZombie],spawnPoints[randSpawn].transform.position, transform.rotation);
                clock = 0;
            }
            else{
                randSpawn = Random.Range(0,spawnPoints.Length);
                if(distance <= Mathf.Sqrt((spawnPoints[randSpawn].transform.position.x - player.transform.position.x)*(spawnPoints[randSpawn].transform.position.x - player.transform.position.x)  + (spawnPoints[randSpawn].transform.position.y - player.transform.position.y)*(spawnPoints[randSpawn].transform.position.y - player.transform.position.y))){
                    Instantiate(zombie[randZombie],spawnPoints[randSpawn].transform.position, transform.rotation);
                    clock = 0;
                }
            }

            
            
        }
    }
}
