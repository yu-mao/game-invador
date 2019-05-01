using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
            TextField.text = "Score: " + value.ToString();
        }
    }

    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

        InitGame();
    }

    void InitGame()
    { }

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
        Debug.Log("Win!");
    }

    void Lose()
    {
        Debug.Log("Lose");
    }

    public void OnDestroyEnemy()
    {
        Score += scoreEnemyDestroied;
    }

    private float offsetDistance = 1f;
    private int score = 0;
    private int scoreEnemyDestroied = 5;
}
