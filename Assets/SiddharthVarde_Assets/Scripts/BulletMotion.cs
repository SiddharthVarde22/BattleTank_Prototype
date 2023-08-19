using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMotion : MonoBehaviour
{
    [SerializeField]
    float lifeTime = 5;
    [SerializeField]
    float damage = 10;

    Rigidbody rigidbody;
    // Start is called before the first frame update
    void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
        Destroy(gameObject, lifeTime);
    }

    public void ShootProjectile(float force)
    {
        rigidbody.AddForce(transform.right * force, ForceMode.Impulse);
        rigidbody.useGravity = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        PlayerHealth player = null;

        if(other.TryGetComponent<PlayerHealth>(out player))
        {
            player.GetHurt(damage);
        }

        Destroy(gameObject);
    }
}
