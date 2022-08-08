using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField] Button startButton;
    [SerializeField] Button exitButton;
    

    //[OneLine] public Test test = new Test();
    //[Serializable]
    //public class Test { 
    //public int a = 4;
    //public int b = 5; }

    private void Awake()
    {
        startButton.onClick.AddListener(OnStartButtonClick);
        exitButton.onClick.AddListener(OnExitButtonClick);
       
    }

    private void OnExitButtonClick()
    {
        LevelManager.Instance.Exit();
    }

    private void OnStartButtonClick()
    {
        LevelManager.Instance.LoadNextLevel();
    }
   
}
