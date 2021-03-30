using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraVida : MonoBehaviour
{
    public Text healthText;
    public Image HealthBar;
    public GameObject TimeIsUp;

    float health, maxHealth = 100;
    float lerpSpeed;
    float speed = -3f;
    public float Sp = 1;

    
    // Start is called before the first frame update
    void Start()
    {
        TimeIsUp.SetActive(false);
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = "Combustible: " + health + " % ";
        if (health > maxHealth) 
            health = maxHealth;
        if (health > 0)
            health -= Sp * Time.deltaTime;
        else
            TimeIsUp.SetActive(true);
        lerpSpeed = speed * Time.deltaTime;
        HealthBarFiller();
        ColorChanger();
    }

    void HealthBarFiller()
    {
        HealthBar.fillAmount = Mathf.Lerp(HealthBar.fillAmount, health / maxHealth, health);
    }

    void ColorChanger()
    {
        Color healthColor = Color.Lerp(Color.red, Color.green, (health / maxHealth));
        HealthBar.color = healthColor;
    }
    void Damage(float damagePoints)
    {
        if (health > 0)
            health -= damagePoints * Time.deltaTime;
    }

    void Heal(float healinPoints)
    {
        if (health < maxHealth)
            health += healinPoints;
    }
}
