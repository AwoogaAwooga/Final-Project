using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public Slider slider;
    public int MaxHealth = 100;
    public int currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = MaxHealth;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Damage(int amount)
    {
        if (amount < 0)
        {
            throw new System.ArgumentOutOfRangeException("cant have negative damage");
        }
        currentHealth -= amount;
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    public void Heal(int amount)
    {
        bool WouldBeOverMaxHealth = currentHealth + amount > MaxHealth;
        if (WouldBeOverMaxHealth)
        {
            this.currentHealth = MaxHealth;
        }
        else
        {
            this.currentHealth += amount;
        }
        if (amount < 0)
        {
            throw new System.ArgumentOutOfRangeException("cant have negative healing");
        }
        
    }
    private void Die()
    {
        Debug.Log("im dead");
        Destroy(gameObject);
        SceneManager.LoadScene("GameOver");
        
    }
    public void SetHealth(int health, int hp)
    {
        slider.value = health;
    }

    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
    }
}  
