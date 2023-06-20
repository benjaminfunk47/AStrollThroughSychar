using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MonsterHealthBar : MonoBehaviour
{
    public Slider slider;
    public Gradient gradient;
    public Image fill;
    public Text currentHP;
    public Text currentMaxHP;
    public Image difficultyOne;
    public Image difficultyTwo;
    public Image difficultyThree;
    public Image difficultyOneBG;
    public Image difficultyTwoBG;
    public Image difficultyThreeBG;
    private float smoothingSpeed = 2f;
    private int currHealth;

    public void SetMonsterMaxHealth(int health){
        slider.maxValue = health;
        currHealth = health;
        currentMaxHP.text = " / " + health.ToString();
        currentHP.text = health.ToString();
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

    public void SetDifficulty(int difficulty){
        if(difficulty == 0){
            difficultyOne.enabled = false;
            difficultyTwo.enabled = false;
            difficultyThree.enabled = false;
            difficultyOneBG.enabled = true;
            difficultyTwoBG.enabled = true;
            difficultyThreeBG.enabled = true;
        }
        if(difficulty == 1){
            difficultyOne.enabled = true;
            difficultyTwo.enabled = false;
            difficultyThree.enabled = false;
            difficultyOneBG.enabled = false;
            difficultyTwoBG.enabled = true;
            difficultyThreeBG.enabled = true;
        }
        if(difficulty == 2){
            difficultyOne.enabled = true;
            difficultyTwo.enabled = true;
            difficultyThree.enabled = false;
            difficultyOneBG.enabled = false;
            difficultyTwoBG.enabled = false;
            difficultyThreeBG.enabled = true;
        }
        if(difficulty == 3){
            difficultyOne.enabled = true;
            difficultyTwo.enabled = true;
            difficultyThree.enabled = true;
            difficultyOneBG.enabled = false;
            difficultyTwoBG.enabled = false;
            difficultyThreeBG.enabled = false;
        }
    }

    void Update(){
        slider.value = Mathf.Lerp(slider.value, currHealth, Time.deltaTime * smoothingSpeed);
        fill.color = gradient.Evaluate(slider.normalizedValue);
    }
}
