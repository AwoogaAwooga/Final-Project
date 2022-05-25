using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healthbar : MonoBehaviour
{
    private HealthSystem HealthSystem;
    public void Setup(HealthSystem healthsystem)
    {
        this.HealthSystem = healthsystem;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Find("Bar").localScale = new Vector3(HealthSystem.getHealthPercent(), 1);
    }
}
