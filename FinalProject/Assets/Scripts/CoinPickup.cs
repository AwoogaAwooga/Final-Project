using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    [SerializeField] private int CoinValue = 25;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag =="Player")
        {
            pickUp(collision);
            
        }
    }

    void pickUp(Collider2D collision)
    {
        ScoreScript.scoreValue += CoinValue;
        Debug.Log("coin picked up");
        Destroy(gameObject);
    }
}
