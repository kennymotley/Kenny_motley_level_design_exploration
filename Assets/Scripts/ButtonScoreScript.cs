using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScoreScript : MonoBehaviour
{
    private ScoreManager scoreManager;
    public float scoreValue = 50;

    // Start is called before the first frame update
    void Start()
    {
        scoreManager = GameObject.FindObjectOfType<ScoreManager>();
    }


    public void AddScoreFromButton()
    {
        scoreManager.AddScore(scoreValue);
    }
}
