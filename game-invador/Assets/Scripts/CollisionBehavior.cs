using UnityEngine;

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
