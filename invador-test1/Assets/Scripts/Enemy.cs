using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Movement
/// Destroy on projectile collision
/// </summary>
public class Enemy : MonoBehaviour
{
    public float EnemyHorizontalSpeed = 0.05f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float enemyPosX = transform.position.x + direction * EnemyHorizontalSpeed;
        float enemyPosY = transform.position.y;
        if (enemyPosX >= screenWidth / 2 || enemyPosX <= -1 * screenWidth / 2)
        {
            direction *= -1f;
            enemyPosY -= enemyVerticalSpeed;
        }
        transform.position = new Vector3(enemyPosX, enemyPosY, 0);

    }

    private void OnDestroy()
    {
        Gameplay.OnDestroyEnemy();
    }

    private Vector3 enemyPos = new Vector3(0f, 2f, 0);  // initial position
    private float enemyVerticalSpeed = 0.1f;
    private float direction = 1f;
    private float screenWidth = 5f;
    //private float screenWidth = Screen.width;
}
