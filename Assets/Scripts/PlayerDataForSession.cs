using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDataForSession : MonoBehaviour
{
    // ENCAPSULATION
    public static PlayerDataForSession Instance { get; private set; }

    private string playername;
    private int playerscore;

    public string PlayerName
    {
        get { return playername; }
        set { playername = value; }
    }
    public int PlayerScore
    {
        get { return playerscore; }
        set { playerscore = value; }
    }

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
        }
        
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
