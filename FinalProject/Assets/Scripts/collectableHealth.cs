using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectableHealth : MonoBehaviour
{
    public AudioClip collectedClip;
    //creating a function to detect when ruby collides with a game object
    void OnTriggerEnter2D(Collider2D other)
    {
        RubyController controller = other.GetComponent<RubyController>();
        if (controller != null)
        {
            if (controller.health < controller.maxHealth)
            {
                controller.ChangeHealth(1);
                Destroy(gameObject);

                controller.PlaySound(collectedClip);
            }

        }
    }
}
