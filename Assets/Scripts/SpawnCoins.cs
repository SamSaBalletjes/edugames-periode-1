using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCoins : MonoBehaviour {
    public GameObject Coins;
    //   public float RespawnTime = 1.0f;




   


    private void Start()
    {
        InvokeRepeating("spawnCoins", 0, 1);
    }
    private void spawnCoins()
    {
        Vector3 position = new Vector3(Random.Range(-99, 99), 3, Random.Range(-99, 99));
        Instantiate(Coins, position, Quaternion.identity);
    }
        
        
        
        
    
}
