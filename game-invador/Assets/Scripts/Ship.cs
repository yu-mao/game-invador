using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    public float Speed = 1f;
    public GameObject Projectile;

    private void Awake()
    {
        shipPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float shipPosX = transform.position.x + (Input.GetAxis("Horizontal") * Speed);
        shipPos = new Vector3(Mathf.Clamp(shipPosX, -1 * screenWidth / 2, screenWidth / 2), transform.position.y, transform.position.z);
        transform.position = shipPos;

        if (Input.GetKeyDown(KeyCode.Space))
            FireProjectile(transform.position);
    }

    void FireProjectile(Vector3 pos)
    {
        Vector3 projectilePos = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        GameObject projectile = Instantiate(Projectile, projectilePos, Quaternion.identity);
        projectile.GetComponent<Rigidbody>().velocity = new Vector3(0, projectileSpeed, 0);
    }

    private Vector3 shipPos;
    private float screenWidth = 5f;
    //private float screenWidth = Screen.width;
    private float projectileSpeed = 10f;
}
