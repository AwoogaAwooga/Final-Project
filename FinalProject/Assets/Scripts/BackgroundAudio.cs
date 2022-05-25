using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundAudio : MonoBehaviour
{
    public static AudioClip playerHitSound, FireSound, enemyDeathSound;
    static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        playerHitSound = Resources.Load<AudioClip>("playerHit");
        FireSound = Resources.Load<AudioClip>("FireSound");
        enemyDeathSound = Resources.Load<AudioClip>("enemyDeathSound");

        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "fire":
                audioSrc.PlayOneShot(FireSound);
                break;
            case "playerHit":
                audioSrc.PlayOneShot(playerHitSound);
                break;
            case "enemyDeath":
                audioSrc.PlayOneShot(enemyDeathSound);
                break;
        }
    }
}
