using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour{

    public int EnemySpeed;
    GameObject m_player;

    void Awake(){
        m_player = GameObject.Find("Player");
    }


    void Update(){
        m_player = GameObject.FindGameObjectWithTag("Player");

        Vector3 localPosition = m_player.transform.position - transform.position;

        localPosition = localPosition.normalized;
        transform.Translate(localPosition.x * Time.deltaTime * EnemySpeed,localPosition.y * Time.deltaTime * EnemySpeed, localPosition.z * Time.deltaTime * EnemySpeed);
    }
}
