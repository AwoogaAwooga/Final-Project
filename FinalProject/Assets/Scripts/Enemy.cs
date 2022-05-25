using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    
    public Rigidbody2D rb;
    public Transform Player;
    public int damage = 20;
    public float speed = 1.5f;
    public GameObject player;
    public int health = 100;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        FollowPlayer();
        Vector3 Direction = Player.position - transform.position;
        float angle = Mathf.Atan2(Direction.y, Direction.x) * Mathf.Rad2Deg;
        rb.rotation = angle;
        
    }

    private void FollowPlayer()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            if (collider.GetComponent<Health>() != null)
            {
                collider.GetComponent<Health>().Damage(damage);
                this.GetComponent<Health>().Damage(damage);
                Destroy(gameObject);
            }
        }
    }



    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            ScoreScript.scoreValue += 10;
            Destroy(gameObject);
            BackgroundAudio.PlaySound("enemyDeath");
        }
    }

}
