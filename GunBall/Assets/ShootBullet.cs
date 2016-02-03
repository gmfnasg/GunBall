using UnityEngine;
using System.Collections;

public class ShootBullet : MonoBehaviour {
    public GameObject BulletBase;
    public float Speed = 1;

	// Use this for initialization
	void Start () {
        if (BulletBase == null)
        {
            BulletBase = GameObject.Find("Bullet");
        }
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Joystick1Button0) || Input.GetKeyDown(KeyCode.X))
        {
            if (BulletBase != null)
            {
                GameObject newBullet = GameObject.Instantiate(BulletBase, transform.position, transform.rotation) as GameObject;
                Rigidbody rb = newBullet.GetComponent<Rigidbody>();
                if (rb != null)
                {
                    rb.AddForce(transform.forward.normalized* Speed);
                }
            }
        }
	}
}
