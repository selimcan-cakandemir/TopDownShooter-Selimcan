using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyAttack : MonoBehaviour
{
    public GameObject explosion;

    private void OnTriggerEnter(Collider other){
        if (other.tag == "Player"){
            SceneManager.LoadScene("Scene1");
            
        }
        else if(other.tag == "Bullet"){
            Destroy(gameObject);
            Instantiate (explosion, transform.position, transform.rotation); 
            EnemyCount.instance.DecreaseSliderValue();
        }
    }

}
