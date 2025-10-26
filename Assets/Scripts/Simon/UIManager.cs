using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    TMP_Text HealthNumber;
    [SerializeField]
    TMP_Text StaminaNumber;
    [SerializeField]
    Slider HealthBarSlider;
    [SerializeField]
    Slider StaminaBarSlider;

    public float health;
    public float stamina;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        health = 10;
        stamina = 50;
    }

    // Update is called once per frame
    void Update()
    {
    HealthBarSlider.value = health;
    StaminaBarSlider.value = stamina;
    HealthNumber.text = health.ToString();
    StaminaNumber.text = stamina.ToString();
        
       
    }
}
