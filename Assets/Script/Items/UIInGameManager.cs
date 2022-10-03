using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Ebac.Core.Singelton;

public class UIInGameManager : Singleton<UIInGameManager>

{
    public TextMeshProUGUI uiTextCoins;


    public static void UpdateTextCoins(string s )
    {
        Instance.uiTextCoins.text = s;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
