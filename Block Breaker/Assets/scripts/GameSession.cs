﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameSession : MonoBehaviour
{

    [Range(0.1f,10f)] [SerializeField] float gameSpeed =1f;

    [Range(10,100)] [SerializeField] int pointsPerBlockDestroyed=14;
    [SerializeField] int currentScore=0;
    [SerializeField] TextMeshProUGUI scoreText;

    private void Awake()
    {
        int gameStatusCount = FindObjectsOfType<GameSession>().Length;
        if (gameStatusCount > 1)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    private void Start()
    {
        scoreText.text = currentScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        Time.timeScale = gameSpeed;
    }

    public void AddToScore()
    {
        currentScore = currentScore + pointsPerBlockDestroyed;
        scoreText.text = currentScore.ToString();
    }

    public void ResetGame()
    {
        Destroy(gameObject);
    }
}
