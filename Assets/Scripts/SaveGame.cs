using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

[SerializeField]
class SaveGame : PersistenceDataPlayer
{
    private string PlayerName;
    private int PlayerScore;
    
    public override void LoadBestPlayer() { }

    public override void SaveBestPlayer(string player, int score)
    {
        
            SaveGame data = new SaveGame();

            data.PlayerName = player;
            data.PlayerScore = score;

            string json = JsonUtility.ToJson(data);

            File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }
    }

