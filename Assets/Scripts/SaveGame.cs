using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

[SerializeField]
class SaveGame : PersistenceDataPlayer
{
    
    public override void LoadBestPlayer() { }

    public override void SaveBestPlayer(string PlayerName, int PlayerScore)
    {

        SaveGame data = new SaveGame
        {
            PlayerName = PlayerName,
            PlayerScore = PlayerScore
        };

        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }
}