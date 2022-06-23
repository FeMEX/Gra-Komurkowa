using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public Text textScore;
    int score = 0;
    Lines lines;
    
   
    void Update()
    {
            if (lines.Cutlines()==true)
            {
                textScore.text = "" + score;
                score++;
            }
    }
}
