using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    //public PickUpCounter pickUpCounter { get; set; }
    [SerializeField] private PickUpCounter pickUpCounter;
    [SerializeField] GameObject winScreen;
    [SerializeField] bool useEscape = false;
   
    public static Game Instance { get; private set; }


    public PickUpCounter PickUpCounter { get { return pickUpCounter; } }
   

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Debug.LogError("—оздание нескольких экземпл€ров Game не разрешено");
            Destroy(this);
        }

        PickUpCounter.OnCollectedAll += Win;
        Time.timeScale = 1f;
    }
    private void Update()
    {
        if (useEscape && Input.GetKeyDown(KeyCode.Escape))
        {
            LevelManager.Instance.LoadMainMenu();
            Time.timeScale = 1f;
        }
    }

    public void Win()
    {
        winScreen.SetActive(true);
        Time.timeScale = 0f;
    }
    

   
    // »зменить систему общени€ пикапкаунтера и гейм через эвенты
    //ƒл€ кнопок сделать скриптовые контроллеры
}
