using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

[SerializeField]
class LoadGame : PersistenceDataPlayer
{

    public override void LoadBestPlayer()
    {
        string path = "C:\\Users\\Carmine\\MyFile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            LoadGame data = JsonUtility.FromJson<LoadGame>(json);

            BestPlayer = data.PlayerName;
            BestScore = data.PlayerScore;

            Debug.Log(path);

        }

    }

    public override void SaveBestPlayer(string name, int score) {}
}
