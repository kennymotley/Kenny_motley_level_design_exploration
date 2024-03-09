using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private float totalScore = 0;
    public TextMeshProUGUI scoreText;

    public void AddScore(float score)
    {
        totalScore += score;

        scoreText.text = "Score: " + totalScore;
        Debug.Log("New Total Score = " + totalScore);
    }
}
