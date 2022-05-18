using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class UIshop : MonoBehaviour
{
    private Transform container;
    private Transform shopItemTemplate;
    private void Awake()
    {
        container = transform.Find("container)");
        shopItemTemplate = transform.Find("shopItemTemplate");
        shopItemTemplate.gameObject.SetActive(false);
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
