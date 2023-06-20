using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthBar : MonoBehaviour
{
    public Slider slider;
    public Gradient gradient;
    public Image fill;
    public Text currentHP;
    public Text currentMaxHP;
    private float smoothingSpeed = 2f;
    private int currHealth;
    private int currMaxHealth;

    public void SetPlayerMaxHealth(int health){
        slider.maxValue = health;
        currMaxHealth = health;
        if(slider.value > 0){
            currHealth = currHealth + 1;
        }

        currentHP.text = currHealth.ToString();
        currentMaxHP.text = " / " + health.ToString();
    }

    public void SetHealth(int health){
        currHealth = health;
        if(health < 0){
            currentHP.text = "0";
        }
        else{
            currentHP.text = health.ToString();
        }
    }

    public void FillHealth(){
        currHealth = (int)slider.maxValue;
        currentHP.text = currHealth.ToString();
    }

    public int GetHealth(){
        return currHealth;
    }

    public int GetMaxHealth(){
        return currMaxHealth;
    }

    void Start(){
        currHealth = (int)slider.value;
        currMaxHealth = (int)slider.maxValue;
    }

    void Update(){
        slider.value = Mathf.Lerp(slider.value, currHealth, Time.deltaTime * smoothingSpeed);
        fill.color = gradient.Evaluate(slider.normalizedValue);
    }
}
