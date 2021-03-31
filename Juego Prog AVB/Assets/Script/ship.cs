using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ship : MonoBehaviour
{
    public GameObject explosion;
    public Image HealthBar;
    public float healtPoints;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer != 6)
        {
            GameObject e = Instantiate(explosion) as GameObject;
            e.transform.position = transform.position;
            Destroy(other.gameObject);
            this.gameObject.SetActive(false);
        }

        if (other.gameObject.layer == 7)
        {
            healtPoints = 10;
            BarraVida.Heal(healtPoints);
            ScoreScript.scoreValue += 50;
        }

        if (other.gameObject.layer == 8)
        {
            healtPoints = 1;
            BarraVida.Heal(healtPoints);
            ScoreScript.scoreValue += 10;
        }
    }
}
