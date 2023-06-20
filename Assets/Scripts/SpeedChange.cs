using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedChange : MonoBehaviour
{
    [SerializeField] private GameLog gameLog;
    [SerializeField] private Button speedButton;
    [SerializeField] private float speed; 

    void Start () {
        gameLog = GameObject.FindObjectOfType<GameLog>();
        speedButton.onClick.AddListener(speedChange);
    }

    public void speedChange(){
        gameLog.setSpeed(speed);
    }
}
