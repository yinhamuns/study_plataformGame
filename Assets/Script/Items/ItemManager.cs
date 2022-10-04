using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Ebac.Core.Singelton;

public class ItemManager : Singleton<ItemManager>
{

    public SOInt coins;
    public SOInt coinsRed;
    
    public TextMeshProUGUI uiTextCoins;


    private void Start()
    {
        Reset();
    }



    private void Reset()
    {
        coins.value = 0;
        coinsRed.value = 0;
        UpdateUI();
    }



    public void AddCoins(string coinColor = "Blue",int amount = 1)
    {

        if(coinColor=="Red")
        {
            coinsRed.value += amount;
        }
        else
        {
            coins.value += amount;

        }
        UpdateUI();
    }

 
    private void UpdateUI()
    {
        //uiTextCoins.text = coins.ToString();
        //UIInGameManager.UpdateTextCoins(coins.value.ToString());
    }
}
