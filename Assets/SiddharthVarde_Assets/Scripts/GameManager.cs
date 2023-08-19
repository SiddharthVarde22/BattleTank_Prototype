using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    
    public Players winner;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }    
    }

    public void OnPlayerDied(Players playerThatDied)
    {
        if(playerThatDied == Players.player1)
        {
            winner = Players.player2;
        }
        else
        {
            winner = Players.player1;
        }

        Debug.Log(winner.ToString());
        LevelChanger.Instance.LoadLevel(2);
    }
}
