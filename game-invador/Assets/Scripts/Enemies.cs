using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour
{
    public float HorizontalSpeed = 0.05f;
    public float VerticalSpeed = 0.05f;
    
    void Update()
    {
        float enemiesPosX = transform.position.x + direction * HorizontalSpeed;
        float enemiesPosY = transform.position.y;

        if (enemiesPosX >= screenWidth / 2 || enemiesPosX <= -1 * screenWidth / 2)
        {
            direction *= -1f;
            enemiesPosY -= VerticalSpeed;
        }

        transform.position = new Vector3(enemiesPosX, enemiesPosY, 0);
    }

    private float direction = 1f;
    private float screenWidth = 5f;
    //private float screenWidth = Screen.width;
}
