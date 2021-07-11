using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundsWall3 : MonoBehaviour
{
    public float rate;
    public GameObject[] enemies;
    public int waves=1;

    void Start()
    {
        InvokeRepeating("SpawnEnemy",rate,rate);
    }


    void SpawnEnemy()
    {
        for(int i=0; i<waves;i++){
            Instantiate(enemies[(int)Random.Range(0,enemies.Length)],new Vector3(Random.Range(-22f,22f),1f,23f),Quaternion.identity);
        }
        
        
    }
}
