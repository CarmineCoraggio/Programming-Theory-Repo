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
    [SerializeField] public Text ScoreBestPlayer;
    [SerializeField] LoadGame dataload = new LoadGame();

    public void Awake()
    {
        
        dataload.LoadBestPlayer();
    
    }

    public void startScene()
    {

        SceneManager.LoadScene("LevelOne");

    }

    public void Start()
    {
        
        SetPlayerName(dataload.BestPlayer,dataload.BestScore);
    }

   public void SetPlayerName(string bestplayer,int bestscore)
    {
       
        ScoreBestPlayer.text = $"Best Player :  {bestplayer}        " +
                               $"Best Score : {bestscore}";
    
    }

    public void SetPlayerName()
    {
        
        PlayerDataForSession.Instance.PlayerName = PlayerNameInput.text;

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
