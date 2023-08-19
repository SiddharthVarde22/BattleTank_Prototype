using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerTurn : MonoBehaviour
{
    [SerializeField]
    GameObject inputUi;
    [SerializeField]
    Movements movements;
    [SerializeField]
    ProjectileShooter shooter;

    private void OnEnable()
    {
        inputUi.SetActive(true);
        movements.enabled = true;
        shooter.enabled = true;
    }

    private void OnDisable()
    {
        if (inputUi != null)
        {
            inputUi.SetActive(false);
        }
        if (movements != null)
        {
            movements.enabled = false;
        }
        if (shooter != null)
        {
            shooter.enabled = false;
        }
    }
}
