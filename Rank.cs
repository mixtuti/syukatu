using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rank : MonoBehaviour
{
    public FinalScore finalScore;
    public Text rankText;
    void Start()
    {
        rankText.text = "C";
        rankText.color = new Color32(123, 40, 0, 255);
    }

    
    void Update()
    {
        if(finalScore.score >= 10000){
            rankText.text = "A";
            rankText.color = new Color32(255, 215, 0, 255);
        }
        else if(finalScore.score >= 6000){
            rankText.text = "B";
            rankText.color = new Color32(192, 192, 192, 255);
        }
    }
}
