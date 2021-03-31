using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BrilloScript1 : MonoBehaviour
{
    public Slider slider;
    public float sliderValue;
    public Image panel_brillo;

    // Start is called before the first frame update
    void Start()
    {
        slider.value = PlayerPrefs.GetFloat("brillo", 0.5f);
        panel_brillo.color = new Color(panel_brillo.color.r, panel_brillo.color.g, panel_brillo.color.b, slider.value);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeSlider(float valor)
    {
        sliderValue = valor;
        PlayerPrefs.SetFloat("brillo", sliderValue);
        panel_brillo.color = new Color(panel_brillo.color.r, panel_brillo.color.g, panel_brillo.color.b, slider.value);
    }
}
