using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject Zombie;
    [SerializeField]
    private float zombInterval = 3.5f;
    private float multiplier = 2f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnEnemy(zombInterval, Zombie));
    }

    // Update is called once per frame
    void Update()
    {
        if (ScoreScript.scoreValue > 150)
        {
            zombInterval *= multiplier;
        }
        if (ScoreScript.scoreValue > 400)
        {
            zombInterval *= multiplier;
        }
        if (ScoreScript.scoreValue > 1000)
        {
            zombInterval *= multiplier;
        }
    }
    private IEnumerator spawnEnemy(float interval, GameObject enemy)
    {
        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-5f, 5), Random.Range(-6f, 6f), 0), Quaternion.identity);
        StartCoroutine(spawnEnemy(interval, enemy));
    }
}
