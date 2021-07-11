using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnemyCount : MonoBehaviour{

    public static EnemyCount instance;
    public Slider slider;

    int enemyAmount = 1;

    private void Awake(){
        instance = this;
    }

    public void DecreaseSliderValue(){
       slider.value -= enemyAmount;
    }

    void Start(){
        
    }


    void Update(){
        if (slider.value == 0){
            SceneManager.LoadScene("Scene1");
        }
    }
}
