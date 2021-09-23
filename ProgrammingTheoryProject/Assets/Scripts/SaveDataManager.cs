using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveDataManager : MonoBehaviour
{

    public string playerName;
    public static SaveDataManager Instance;

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
