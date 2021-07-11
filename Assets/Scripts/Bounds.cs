using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounds : MonoBehaviour
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
            Instantiate(enemies[(int)Random.Range(0,enemies.Length)],new Vector3(22f,1f,Random.Range(-22f,22f)),Quaternion.identity);
        }
        
        
    }
}
