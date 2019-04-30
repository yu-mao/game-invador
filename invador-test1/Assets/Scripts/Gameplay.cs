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
    public GameObject EnemiesObj;
    public GameObject ShipObj;
    public int Score
    {
        get { return this.score; }
        set
        {
            this.score = value;
            TextField.text = "Score: " + value.ToString();
        }
    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        CheckWinLose(enemies);
    }

    public void OnDestroyEnemy()
    {
        this.Score += scoreDestroyEnemy;
    }

    private void CheckWinLose(GameObject[] go)
    {
        if (go.Length == 0) Win();

        float downY = float.MaxValue;
        foreach (GameObject enemy in go)
        {
            if (enemy.transform.position.y < downY)
            {
                downY = enemy.transform.position.y;
            }
        }
        if (downY - minDistanceEnemyShip <= ShipObj.transform.position.y) Lose();
    }

    private void Win()
    {
        Debug.Log("Win!");
    }

    private void Lose()
    {
        Debug.Log("Lose!");
    }

    private static int scoreDestroyEnemy = 10;
    private int score = 0;
    private float enemySpaceHeight = Screen.height - 2f;
    private float minDistanceEnemyShip = 1f;
}
