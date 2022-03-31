using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public static Score instance;
    public TextMeshPro scoreAmount;

    private int playerScore;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        scoreAmount.text = string.Empty;
        playerScore = 0;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    public void AddScore(int scoreToAdd)
    {
        playerScore += scoreToAdd;
        scoreAmount.text = playerScore.ToString();
    }
}
