using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using System.Text.RegularExpressions;
using UnityEngine.EventSystems;

public class MenuButtons : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject inputWindow;
    [SerializeField] private GameObject newGameButton;
    [SerializeField] private GameObject continueButton;
    [SerializeField] private GameObject creditsButton;
    [SerializeField] private GameObject acceptButton;
    [SerializeField] private GameObject cancelButton;
    [SerializeField] private TMP_InputField input;

    private bool characterStored;

    public void GetName(){
        inputWindow.SetActive(true);
        newGameButton.SetActive(false);
        continueButton.SetActive(false);
        creditsButton.SetActive(false);
    }

    public void Cancel(){
        inputWindow.SetActive(false);
        newGameButton.SetActive(true);
        creditsButton.SetActive(true);
        if(characterStored){
            continueButton.SetActive(true);
        }
    }

    public void CheckName(){
        string enteredName = input.text;
        bool isLetters = Regex.IsMatch(enteredName, @"^[a-zA-Z ]+$");
        if(isLetters && enteredName.Length < 16){
            characterStored = true;
            Cancel();
            NewGame();
            GameObject.Find("PlayerChar").GetComponent<PlayerCharacter>().playerCharacter = new Character(enteredName, 10, 10, 10, 10, 10, "PHYSICAL", 0, 0, 0);
        }
    }

    public void NewGame(){
        SceneManager.LoadScene("GameScene");
    }

    public void CreditsScene(){
        Destroy(GameObject.Find("PlayerChar"));
        SceneManager.LoadScene("Credits");
    }

    public void OnPointerClick(PointerEventData eventData){
        if(eventData.pointerPress == newGameButton){
            GetName();
        }
        if(eventData.pointerPress == continueButton){
            
        }
        if(eventData.pointerPress == creditsButton){
            CreditsScene();
        }
        if(eventData.pointerPress == acceptButton){
            CheckName();
        }
        if(eventData.pointerPress == cancelButton){
            Cancel();
        }
    } 
}
