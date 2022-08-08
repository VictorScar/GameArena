using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinScreen : MonoBehaviour
{
    [SerializeField] Button restartButton;
    [SerializeField] Button toMainMenuButton;
    [SerializeField] Button toToNextLevelButton;
    private void Awake()
    {
        restartButton.onClick.AddListener(OnRestartButtonClick);
        toMainMenuButton.onClick.AddListener(OnToMainMenuButtonClick);
        toToNextLevelButton.onClick.AddListener(OnNextLevelButtonClick);

    }

    private void OnToMainMenuButtonClick()
    {
        LevelManager.Instance.LoadMainMenu();
    }

    private void OnRestartButtonClick()
    {
        LevelManager.Instance.Restart();
    }
    private void OnNextLevelButtonClick()
    {
        LevelManager.Instance.LoadNextLevel();
    }
}
