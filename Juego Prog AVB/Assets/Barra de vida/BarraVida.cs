using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraVida : MonoBehaviour
{
    public Text healthText;
    public Image HealthBar;
    public GameObject TimeIsUp;
    public GameObject explosion;
    public float healtPoints;
    public GameObject Galushi;

    public float health, maxHealth = 100;
    float lerpSpeed;
    float speed = -3f;
    public float Sp = 1;
    static float VidaEstatica = 100;

    // Start is called before the first frame update
    void Start()
    {
        TimeIsUp.SetActive(false);
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (VidaEstatica > health)
        {
            health = VidaEstatica;
        }
        else
        {
            VidaEstatica = health;
        }
        healthText.text = "Combustible: " + Math.Truncate(health) + " % ";
        if (health > maxHealth)
            health = maxHealth;
        if (health > 0)
        {
            health -= Sp * Time.deltaTime;
            VidaEstatica -= Sp * Time.deltaTime;
        }
        else
            TimeIsUp.SetActive(true);
        lerpSpeed = speed * Time.deltaTime;
        HealthBarFiller();
        ColorChanger();
        CantidadVida();
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
    public static void Heal(float healinPoints)
    {
        VidaEstatica += healinPoints;
    }

    public static float CantidadVida()
    {
        return VidaEstatica;
    }
}
