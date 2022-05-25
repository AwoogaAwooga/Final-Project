using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public static int scoreValue = 0;
    public Text score;
    CoinPickup coin;
    float _Value = 25;
    public float maxScore = 10000000;

    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Score: " + scoreValue;
    }

   void AddScore(float _Value)
    {
        scoreValue = (int)Mathf.Clamp(scoreValue + _Value, 0, maxScore);
    }
}
