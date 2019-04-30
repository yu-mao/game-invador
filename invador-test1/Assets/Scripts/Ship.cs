using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    public float TankSpeed = 1f;
    public GameObject Projectile;

    /// <summary>
    /// Right/Left keys for side movement
    /// Space key to fire projectiles
    /// </summary>
    void Update()
    {
        float tankPosX = transform.position.x + (Input.GetAxis("Horizontal") * TankSpeed);
        tankPos = new Vector3(Mathf.Clamp(tankPosX, -1 * screenWidth / 2, screenWidth / 2), -1f, 0);
        transform.position = tankPos;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            FireProjectile(transform.position);
        }
    }

    void FireProjectile(Vector3 pos)
    {
        GameObject projectile = Instantiate(Projectile, transform.position, Quaternion.identity);
        projectile.GetComponent<Rigidbody>().velocity = projectileSpeed;
    }

    private Vector3 tankPos = new Vector3(0, -1f, 0);
    private float screenWidth = 5f;
    private Vector3 projectileSpeed = new Vector3(0, 1f, 0);
    //private float screenWidth = Screen.width;
}
