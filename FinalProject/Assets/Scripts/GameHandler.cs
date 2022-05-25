using UnityEngine;
using CodeMonkey;

public class GameHandler : MonoBehaviour
{
    public Healthbar healthbar;
    // Start is called before the first frame update
    void Start()
    {
        HealthSystem healthsystem = new HealthSystem(100);
        healthbar.Setup(healthsystem);

        Debug.Log("Health: " + healthsystem.getHealthPercent());
        healthsystem.Damage(10);
        Debug.Log("Health: " + healthsystem.getHealthPercent());



        CMDebug.ButtonUI(new Vector2(100, 100), "damage", () =>
       {
           healthsystem.Damage(10);
           Debug.Log("damaged: " + healthsystem.getHealthPercent());
       });

        CMDebug.ButtonUI(new Vector2(-100, 100), "heal", () =>
        {
            healthsystem.Heal(10);
            Debug.Log("healed: " + healthsystem.getHealthPercent());
        });
    }

    // Update is called once per frame
    void Update()
    {

    }
}