using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    ScoreScript scoreScript;
    [SerializeField] private float CoinValue = 25;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider Player)
    {
        
        if(Player.tag == "Player")
        {
            CoinPickup();
        }
    }

    private void CoinPickup(Collider player)
    {
        scoreScript.score.text = "Score: " + CoinValue + ScoreScript.scoreValue;

        Destroy(gameObject);
    }
}
