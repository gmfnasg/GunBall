using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
    
    void Update()
    {
        if(Vector3.Distance(transform.position, Vector3.zero)> 100)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter(Collision col)
    {
        Destroy(gameObject);
    }
}
