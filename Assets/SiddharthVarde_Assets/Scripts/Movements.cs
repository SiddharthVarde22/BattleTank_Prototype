using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movements : MonoBehaviour
{
    [SerializeField]
    float tankSpeed = 5;

    float horizontalInput;



    // Start is called before the first frame update
    void Start()
    {
        //float height;
        //float distance = ProjectileMotionCalculator.Instance.CalculateProjectileMotion(45, 10, out height);

        //Debug.Log("Distance " + distance + " height " + height);
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        transform.position += transform.right * horizontalInput * tankSpeed * Time.deltaTime;
    }
}
