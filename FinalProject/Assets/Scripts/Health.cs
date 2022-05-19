using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    [SerializeField]
    private int health = 100;
    private int MAX_HEALTH = 100;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void SetHealth(int maxHealth, int health)
    {
        this.MAX_HEALTH = maxHealth;
        this.health = health;
    }

    public void Damage(int amount)
    {
        if (amount < 0)
        {
            throw new System.ArgumentOutOfRangeException("cant have negative damage");
        }
        this.health -= amount;
        if (health <= 0)
        {
            Die();
        }
    }

    public void Heal(int amount)
    {
        bool WouldBeOverMaxHealth = health + amount > MAX_HEALTH;
        if (WouldBeOverMaxHealth)
        {
            this.health = MAX_HEALTH;
        }
        else
        {
            this.health += amount;
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
}  
