using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    public static ScoreCounter instance;

    public Text MyText;
    private int score;
 
    private void Awake(){
        instance = this;
    }
 
    void Start () {
   
        MyText.text = "";
 
    }
 
 
    void Update () {
   
        MyText.text = "" + score;
 
    }
 
 
    public void UpScore() {
 
        ++score;
    }

    public void ResetScore(){
        score=0;
    }
}
