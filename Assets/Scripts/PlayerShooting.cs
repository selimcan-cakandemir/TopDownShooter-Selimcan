using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour{

    public GameObject BulletPrefab;
    public Transform BulletSpawn;
    private AudioSource m_AudioSource;

    public float TimeBetweenShots = 0.3333f;
    private float m_timeStamp = 0f;

    private void Start(){
         m_AudioSource = GetComponent<AudioSource>();
    }
    
    void FixedUpdate(){
        if((Time.time >= m_timeStamp) && (Input.GetKey(KeyCode.Mouse0))){
            Fire();
            m_timeStamp = Time.time + TimeBetweenShots;
        }
    }

    void Fire(){
        var bullet = (GameObject)Instantiate(BulletPrefab, BulletSpawn.position, BulletSpawn.rotation);

        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 50;

        Destroy(bullet, 2.0f);

        m_AudioSource.PlayOneShot(m_AudioSource.clip);
    }
}
