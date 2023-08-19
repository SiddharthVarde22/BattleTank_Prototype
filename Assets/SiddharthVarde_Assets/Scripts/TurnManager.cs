using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Players
{
    player1,
    player2
}

public class TurnManager : MonoBehaviour
{
    public static TurnManager Instance { get; private set; }

    Players currentPlayer = Players.player2;

    [SerializeField]
    PlayerTurn player1, player2;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        ChangePlayerTurn();
    }

    public void ChangePlayerTurn()
    {
        if(currentPlayer == Players.player1)
        {
            currentPlayer = Players.player2;
            player2.enabled = true;
            player1.enabled = false;
        }
        else
        {
            currentPlayer = Players.player1;
            player1.enabled = true;
            player2.enabled = false;
        }
    }
}
