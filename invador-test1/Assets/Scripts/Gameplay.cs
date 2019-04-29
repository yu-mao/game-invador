using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Load intro, main, ending scenes
/// Add scores when destroying enemies
/// Implement win/lose conditions
/// </summary>
public class Gameplay : MonoBehaviour
{
    public Text TextField;
    public int Score
    {
        get { return this.score; }
        set
        {
            this.score = value;
            TextField.text = "Score: " + value.ToString();
        }
    }

    private void Awake()
    {
        this.score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnDestroyEnemy()
    {
        this.Score += scoreDestroyEnemy;
    }

    private void Win()
    {
    }

    private void Lose()
    {
    }

    private static int scoreDestroyEnemy = 10;
    private int score;
}
