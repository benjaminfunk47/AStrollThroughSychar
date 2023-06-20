using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKeyDown("escape"))
            Application.Quit();
    }

    public void Home(){
        SceneManager.LoadScene("MainMenu");
    }
}
