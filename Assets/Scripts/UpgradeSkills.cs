using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeSkills : MonoBehaviour
{
    [SerializeField] private Button skillButton;
    [SerializeField] private GameObject attributePointObject;
    [SerializeField] private GameObject skillPointObject;

    void Start () {
        skillButton.onClick.AddListener(skillUpgrade);
    }

    void skillUpgrade () {
        Text attributeText = attributePointObject.GetComponent<Text>();
        int attributePointAmount = int.Parse(attributeText.text);

        if(attributePointAmount > 0){
            Text skillText = skillPointObject.GetComponent<Text>();
            int skillNumber = int.Parse(skillText.text);
            skillNumber += 1;
            skillText.text = skillNumber.ToString();

            attributePointAmount -= 1;
            attributeText.text = attributePointAmount.ToString();
        }
    }
}
