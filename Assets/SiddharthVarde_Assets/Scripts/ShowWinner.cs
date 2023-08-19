using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowWinner : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI winningText;
    // Start is called before the first frame update
    void Start()
    {
        winningText.text = "GameOver\nWinner is - " + GameManager.Instance.winner.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
