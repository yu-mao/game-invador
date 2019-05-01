using System.Collections;
using System.Collections.Generic;
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

            if (collision.gameObject.tag == "Enemy")
            {
                //var audio = collision.collider.GetComponent<AudioSource>();
                //audio.Play();
                Audio.Play();
                Debug.Log(Audio.name);
            }

            //var audioLala = gameObject.GetComponent<AudioSource>();
            //audioLala.Play();
            //Debug.Log("Audio");
            //Audio.Play(0);
            //transform.GetComponent<SoundEffect>().PlayAudio();
        }
    }
}
