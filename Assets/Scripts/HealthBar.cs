using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public TMP_Text healthText;
    public PlayerHealth playerHealth;
   
    // Start is called before the first frame update
    void Start()
    {

        playerHealth = GetComponent<PlayerHealth>();

        Debug.Log(healthText.text);
        Debug.Log(playerHealth.health);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
