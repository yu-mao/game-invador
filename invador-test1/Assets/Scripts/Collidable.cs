using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collidable : MonoBehaviour
{
    public GameObject GameplayObj;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy" || collision.gameObject.tag == "Projectile")
        {
            Destroy(collision.gameObject);
            GameObject.FindGameObjectWithTag("Gameplay").GetComponent<Gameplay>().OnDestroyEnemy();
        }
    }
    
}
