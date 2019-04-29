using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject GameplayObj;
    public float EnemyHorizontalSpeed = 0.05f;

    /// <summary>
    /// Move enemy in given vertical & horizontal pattern
    /// Detect projectile collision with enemy
    /// </summary>
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

    /// <summary>
    /// rotate enemy so that the y-axis faces along the normal of the surface
    /// then destroy the enemy
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionEnter(Collision collision)
    {
        ContactPoint contact = collision.contacts[0];
        Quaternion rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
        Vector3 pos = contact.point;
        OnDestroyEnemy(transform);
    }

    private void OnDestroyEnemy(Transform t)
    {
        Destroy(t.gameObject);
        GameplayObj.GetComponent<Gameplay>().OnDestroyEnemy();
    }

    private Vector3 enemyPos = new Vector3(0f, 2f, 0);  // initial position
    private float enemyVerticalSpeed = 0.1f;
    private float direction = 1f;
    private float screenWidth = 5f;
    //private float screenWidth = Screen.width;
}
