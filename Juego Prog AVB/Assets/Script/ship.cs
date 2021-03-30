using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ship : MonoBehaviour
{
    public GameObject explosion;
    public Image HealthBar;

    float health, maxHealth = 100;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("hit detected");
        GameObject e = Instantiate(explosion) as GameObject;
        e.transform.position = transform.position;
        Destroy(other.gameObject);
        this.gameObject.SetActive(false);

        health += 15; 


    }

    void HealthBarFiller()
    {
        //HealthBar.fillAmount = Mathf.Lerp(HealthBar.fillAmount, health / maxHealth, health);
    }

}
