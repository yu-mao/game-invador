using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionLayer : MonoBehaviour
{
    public GameObject GameplayObj;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("destroy");
        Collider col1 = collision.contacts[0].thisCollider;
        Collider col2 = collision.contacts[0].otherCollider;
        OnDestroyCollider(col1);
        OnDestroyCollider(col2);
        Debug.Log(col1.gameObject.name);

    }

    void OnDestroyCollider(Collider col)
    {
        Debug.Log("destroy!");
        Destroy(col.gameObject);
        //GameplayObj.GetComponent<Gameplay>().OnDestroyEnemy();
    }
}
