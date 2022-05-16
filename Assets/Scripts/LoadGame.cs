using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

[SerializeField]
class LoadGame : PersistenceDataPlayer
{

    public override void LoadBestPlayer()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            LoadGame data = JsonUtility.FromJson<LoadGame>(json);

            BestPlayer = data.PlayerName;
            BestScore = data.PlayerScore;

        }
        
    }

    public override void SaveBestPlayer(string PlayerName, int PlayerScore) {}
}
