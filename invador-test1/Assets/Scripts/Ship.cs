using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    public float ShipSpeed = 1f;
    public GameObject Projectile;

    private void Awake()
    {
        shipPos = transform.position;
    }

    /// <summary>
    /// Right/Left keys for side movement
    /// Space key to fire projectiles
    /// </summary>
    void Update()
    {
        float shipPosX = transform.position.x + (Input.GetAxis("Horizontal") * ShipSpeed);
        shipPos = new Vector3(Mathf.Clamp(shipPosX, -1 * screenWidth / 2, screenWidth / 2), -1f, 0);
        transform.position = shipPos;

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

    private Vector3 shipPos = new Vector3(0, -6f, 0);
    private float screenWidth = 5f;
    private Vector3 projectileSpeed = new Vector3(0, 2f, 0);
    //private float screenWidth = Screen.width;
}
