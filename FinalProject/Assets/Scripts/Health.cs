using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    private HealthSystem healthsystem;
    private Enemy enemy;

    // Start is called before the first frame update
    void Start()
    {
        healthsystem.health = healthsystem.healthMax;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Damage(int damage)
    {
        healthsystem.health -= enemy.damage;
        if (healthsystem.health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Debug.Log("im dead");
        Destroy(gameObject);
        SceneManager.LoadScene("GameOver");

    }
}
