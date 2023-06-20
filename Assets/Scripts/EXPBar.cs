using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EXPBar : MonoBehaviour
{
    public Slider slider;
    public Gradient gradient;
    public Image fill;
    public Text attributePoints;
    public Text level;
    private int nextValue;
    private int nextLevel;
    public Text currentEXP;
    public Text currentMaxEXP;
    private float smoothingSpeed = 1.5f;
    private int currEXP;

    public void AddEXP(int exp){
        if(slider.maxValue <= (slider.value + exp)){
            nextValue = ((int)slider.value + exp) - (int)slider.maxValue;
            currentEXP.text = nextValue.ToString();
            slider.maxValue += 30;
            int cMaxExp = (int)slider.maxValue;
            currentMaxEXP.text = " / " + cMaxExp.ToString();
            currEXP = nextValue;
            nextLevel = int.Parse(level.text);
            nextLevel += 1;
            level.text = nextLevel.ToString();
            attributePoints.text = (int.Parse(attributePoints.text) + 3).ToString();
        }
        else{
            currEXP += exp;
            currentEXP.text = currEXP.ToString();
        }
    }

    void Start(){
        currEXP = (int)slider.value;
    }

    void Update(){
        slider.value = Mathf.Lerp(slider.value, currEXP, Time.deltaTime * smoothingSpeed);
        fill.color = gradient.Evaluate(slider.normalizedValue);
    }
}
