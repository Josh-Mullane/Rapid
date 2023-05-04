using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using unityEngine.UI;

public class HealthComponent : MonoBehaviour
{
    public float health;
    public Image healthBar;
    public bool hasHealthBar;

    void Update()
    {
        if (hasHealthBar)
        {
            healthBar.fillAmount = health / 100;
        }
    }

    public void TakeDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
