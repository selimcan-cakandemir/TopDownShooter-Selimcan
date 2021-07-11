using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlayer : MonoBehaviour
{
    public static SpawnPlayer instance;
    public Transform respawnPoint;
    public GameObject playerPrefab;
 
    private void Awake(){
        instance = this;
    }


    public void Respawn(){
        GameObject player = Instantiate(playerPrefab, respawnPoint.position, Quaternion.identity);
        player.gameObject.tag="Player";  
    }
}
