using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField]
    float maxHealth = 100;
    float health = 100;
    [SerializeField]
    Image healthBar;
    [SerializeField]
    Players player;

    // Start is called before the first frame update
    void Start()
    {
        SetHealthBar();
    }

    public void GetHurt(float damage)
    {
        health -= damage;
        if(health <= 0)
        {
            GameManager.Instance.OnPlayerDied(player);
        }
        SetHealthBar();
    }

    public void SetHealthBar()
    {
        healthBar.fillAmount = health / maxHealth;
    }
}
