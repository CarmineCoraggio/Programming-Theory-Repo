using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuHandler : MonoBehaviour
{

    [SerializeField] Text PlayerNameInput;
    public Text MenuPlayer;
    LoadGame data = new LoadGame();

    public void Awake()
    {
        
        data.LoadBestPlayer();
    
    }

    public void startScene()
    {
        SceneManager.LoadScene("LevelOne");

    }

    public void Start()
    {
        Show();
    }


    public void Show()
    {
       
        MenuPlayer.text = $"Best Player :  {data.BestPlayer}        Best Score : {data.BestScore}";
    }

    public void SetPlayerName()
    {
        PlayerData.Instance.PlayerName = PlayerNameInput.text;

    }


    public void ExitGame()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }

}
