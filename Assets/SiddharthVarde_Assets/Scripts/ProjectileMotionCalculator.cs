using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMotionCalculator : MonoBehaviour
{
    public static ProjectileMotionCalculator Instance { get; private set; }

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    //public float CalculateProjectileMotion(float angle, float force, out float height)
    //{
    //    //height = ((force * Mathf.Sin(angle)) * (force * Mathf.Sin(angle))) / (2 * Physics.gravity.y * -1);

    //    //float distance = ((force * force) * Mathf.Sin(2 * angle)) / (Physics.gravity.y * -1);

    //    //return distance;
    //}

    
}
