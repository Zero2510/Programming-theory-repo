using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private Text playerNameText;



    void Start()
    {
        UpdatePlayerName(); 
    }



    void UpdatePlayerName()
    {

        playerNameText.text = "Player: " + SaveDataManager.Instance.PlayerName;

    }
    
}
