using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletProjectile : MonoBehaviour
{
    [SerializeField] private Transform vfxHitGreen;
    [SerializeField] private Transform vfxHitRed;
    private Rigidbody bulletRigidBody;

    private void Awake()
    {
        bulletRigidBody = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        float speed = 80f;
        bulletRigidBody.velocity = transform.forward * speed;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<BulletTarget>() != null)
        {
            // Hit target
            Transform greenEffect = Instantiate(vfxHitGreen, transform.position, Quaternion.identity);
            Destroy(greenEffect.gameObject, 2f); // Destroy after 2 seconds
        }
        else
        {
            // Hit something else
            Transform redEffect = Instantiate(vfxHitRed, transform.position, Quaternion.identity);
            Destroy(redEffect.gameObject, 2f); // Destroy after 2 seconds
        }
        Destroy(gameObject); // Destroy the bullet projectile immediately
    }
}
