using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int MaxHealth;
    public int currentHealth;
    public Text HealthValueText;
    public AudioClip playerHitSound;
    float _Value = 25;

    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        MaxHealth = 100;
        currentHealth = MaxHealth;
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        HealthValueText.text = "Health: " + currentHealth;
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
            PlaySound(playerHitSound);
        }
    }
    public void addHealth(float _Value)
    {
        currentHealth = (int)Mathf.Clamp(currentHealth + _Value, 0, MaxHealth);
    }

    private void Die()
    {
        Debug.Log("im dead");
        Destroy(gameObject);
        SceneManager.LoadScene("GameOver");

    }

    public void PlaySound(AudioClip clip)
    {
        audioSource.PlayOneShot(clip);

    }
}  
