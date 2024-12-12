using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class ScoreGame : MonoBehaviour
{
    public TextMeshProUGUI scoreText; 
    private int score; 

    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score; 
    }

    public int GetScore()
    {
        return score; 
    }
}














    

