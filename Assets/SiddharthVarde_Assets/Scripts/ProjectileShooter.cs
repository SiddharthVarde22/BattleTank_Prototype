using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProjectileShooter : MonoBehaviour
{
    [SerializeField]
    Slider angleSlider, forceSlider;

    float angle, force;
    [SerializeField]
    GameObject projectile;
    [SerializeField]
    Transform startPointOfProjectile;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        angle = angleSlider.value;
        force = forceSlider.value;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            BulletMotion x = Instantiate(projectile, startPointOfProjectile.position, Quaternion.Euler(0, 0, angle)).GetComponent<BulletMotion>();
            //BulletMotion x = projectile.GetComponent<BulletMotion>();
            x.ShootProjectile(force);

            TurnManager.Instance.ChangePlayerTurn();
        }
    }
}
