using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muerte : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject Galushi;
    public GameObject explosion;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (BarraVida.CantidadVida() <= 0)
        {
            Destroy(gameObject);
            GameObject e = Instantiate(explosion) as GameObject;
            e.transform.position = transform.position;
            this.gameObject.SetActive(false);
        }
    }
}
