using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour
{
    public float EnemiesHorizontalSpeed = 0.05f;
    public float EnemiesVerticalSpeed = 0.05f;
    public GameObject GameplayObj;

    /// <summary>
    /// Move enemy in given vertical & horizontal pattern
    /// Detect projectile collision with enemy
    /// </summary>
    void Update()
    {
        float enemiesPosX = transform.position.x + direction * EnemiesHorizontalSpeed;
        float enemiesPosY = transform.position.y;

        if (enemiesPosX >= screenWidth / 2 || enemiesPosX <= -1 * screenWidth / 2)
        {
            direction *= -1f;
            enemiesPosY -= EnemiesVerticalSpeed;
        }
        transform.position = new Vector3(enemiesPosX, enemiesPosY, 0);
    }

    private float direction = 1f;
    private float screenWidth = 5f;
    //private float screenWidth = Screen.width;

}
