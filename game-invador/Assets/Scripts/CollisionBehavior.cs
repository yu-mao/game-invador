using UnityEngine;

/// <summary>
/// Destroy collided gameobjects if tagged as Enemy or Projectile
/// </summary>
public class CollisionBehavior : MonoBehaviour
{
    public AudioSource Audio;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy" || collision.gameObject.tag == "Projectile")
        {
            Destroy(collision.gameObject);
            GameManager.instance.OnDestroyEnemy();
        }
    }
}
