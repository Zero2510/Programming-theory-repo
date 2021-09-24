using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveDataManager : MonoBehaviour
{
    

    private string playerName;
    // ENCAPSULATION
    public string PlayerName
    {
        get
        {
            return playerName;
        }
        set
        {
            playerName = value;
        }
    }




    public static SaveDataManager Instance { get; private set; }

    void Awake()
    {
        if(Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);



    }


    public void SaveData(string playerName)
    {

        this.playerName = playerName;

    }

    

}
