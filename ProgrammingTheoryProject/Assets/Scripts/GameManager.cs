using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public Text playerNameText;

    void Start()
    {
        UpdatePlayerName(); 
    }



    void UpdatePlayerName()
    {

        playerNameText.text = "Player: " + SaveDataManager.Instance.playerName;

    }

}
