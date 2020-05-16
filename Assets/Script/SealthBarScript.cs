using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SealthBarScript : MonoBehaviour
{    public PlayerScript oyuncu;
    private Image healthBar;



    void Start()
    {
        healthBar = GetComponent<Image>();
    }

    void Update()
    {
        healthBar.fillAmount = oyuncu.health / 100;
    }
}