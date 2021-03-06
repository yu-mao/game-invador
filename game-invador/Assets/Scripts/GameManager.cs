﻿using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Check win and lose conditions
/// </summary>
public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;
    public Text TextField;
    public GameObject ShipObj;
    public int Score
    {
        get { return score; }
        set
        {
            score = value;
            TextField.text = "SCORE: " + value.ToString();
        }
    }
    public GameObject YouWinObj;
    public GameObject GameoverObj;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);
        
    }

    private void Update()
    {
        CheckWinLose();
    }

    void CheckWinLose()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        if (enemies.Length == 0)
        {
            Win();
        }
        else
        {
            float minEnemyPosY = float.MaxValue;
            foreach (var enemy in enemies)
            {
                if (enemy.transform.position.y < minEnemyPosY)
                    minEnemyPosY = enemy.transform.position.y;
            }
            if (minEnemyPosY - offsetDistance <= ShipObj.transform.position.y)
                Lose();
        }
    }

    void Win()
    {
        YouWinObj.SetActive(true);
        Time.timeScale = .25f;
        Invoke("LoadEndingScene", .5f);
        //Invoke("Reset", 1f);
    }

    void Lose()
    {
        GameoverObj.SetActive(true);
        Time.timeScale = .25f;
        Invoke("LoadEndingScene", .5f);
        //Invoke("Reset", 1f);
    }

    private void LoadEndingScene()
    {
        Time.timeScale = 1f;
        Application.LoadLevel("Ending");
    }

    public void OnDestroyEnemy()
    {
        Score += scoreEnemyDestroied;
    }

    private float offsetDistance = 1f;
    private int score = 0;
    private int scoreEnemyDestroied = 5;
}
