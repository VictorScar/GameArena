using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    [SerializeField] LevelSetup levelSetup;
    int currentLevel = 0;
    public static LevelManager Instance { get; private set; }


    
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Debug.LogError("Создание нескольких экземпляров LevelManager не разрешено");
            Destroy(this);
        }
       
        LoadMainMenu();
    }
    public void Restart()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        LoadScene(currentScene.name);
    }
    private void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
        
    }
    public void Exit()
    {
        Debug.Log("Выходим из игры");
        Application.Quit();
    }
    public void LoadMainMenu ()
    {
        LoadScene(levelSetup.menuScene);
        currentLevel = 0;
    }
    public void LoadNextLevel()
    {
        if (currentLevel >= levelSetup.levelScenes.Count)
        {
            currentLevel = 0;
        }
        LoadScene(levelSetup.levelScenes[currentLevel]);
        currentLevel++;
    }
}
//Доделать скриптбл обджект
//Current level