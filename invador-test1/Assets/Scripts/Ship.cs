using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Right/Left keys for side movement
/// Space to file projectiles
/// </summary>
public class Ship : MonoBehaviour
{
    public float TankSpeed = 1f;

    private void Awake()
    {
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float tankPosX = transform.position.x + (Input.GetAxis("Horizontal") * TankSpeed);
        tankPos = new Vector3(Mathf.Clamp(tankPosX, -1 * screenWidth / 2, screenWidth / 2), -1f, 0);
        transform.position = tankPos;
    }

    private Vector3 tankPos = new Vector3(0, -1f, 0);
    private float screenWidth = 5f;
    //private float screenWidth = Screen.width;
}
