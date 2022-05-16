using System.Collections;
using System.Collections.Generic;

//ASTRACTION
abstract class PersistenceDataPlayer
{
    public string PlayerName;
    public int PlayerScore;

    public string BestPlayer;
    public int BestScore;
    
    public abstract void  LoadBestPlayer();
    public abstract void  SaveBestPlayer(string Player, int Score);

}



