using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody2D rb;
    public Transform Player;
    public int damage = 25;
    public float speed = 1.5f;
    public AudioClip enemyDeathSound;
    

    [SerializeField]
    private GameObject player;
    public int health = 100;
    public List<GameObject> droppeditems = new List<GameObject>();

    public bool isRandomized;

    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
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
                Destroy(gameObject);
                PlaySound(enemyDeathSound);
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
            PlaySound(enemyDeathSound);
            SpawnObjects();
            
        }
    }

    public void SpawnObjects()
    {
        int index = isRandomized ? Random.Range(0, droppeditems.Count) : 0;
        if (droppeditems.Count > 0)
        {
            Instantiate(droppeditems[index], transform.position, Quaternion.identity);

        }

    }

      public void PlaySound(AudioClip clip)
    {
        audioSource.PlayOneShot(clip);

    }
}
