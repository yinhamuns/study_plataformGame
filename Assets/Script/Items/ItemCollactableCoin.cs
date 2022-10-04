using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollactableCoin : ItemCollectableBase

{
    public string color;



    protected override void OnCollect()
    {
        base.OnCollect();

        if (color == "Red")
        {
            ItemManager.Instance.AddCoins("Red");
        }
        else
        {
            ItemManager.Instance.AddCoins();
        }
        
       
    }
}
