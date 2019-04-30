using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour
{
    public GameObject GameplayObj;
    public float EnemiesHorizontalSpeed = 0.05f;
    public float EnemiesVerticalSpeed = 0.05f;

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

    /// <summary>
    /// rotate enemy so that the y-axis faces along the normal of the surface
    /// then destroy the enemy
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionEnter(Collision collision)
    {
        //ContactPoint contact = collision.contacts[0];
        //Quaternion rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
        //Vector3 pos = contact.point;
        OnDestroyEnemy(transform);
    }

    private void OnDestroyEnemy(Transform t)
    {
        Destroy(t.gameObject);
        GameplayObj.GetComponent<Gameplay>().OnDestroyEnemy();
    }

    private float direction = 1f;
    private float screenWidth = 5f;
    //private float screenWidth = Screen.width;

}
