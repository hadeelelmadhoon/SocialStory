using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyCounter : MonoBehaviour
{
      
    public Text moneyText;

    public void SetMoneyCount(int money){
        moneyText.text = money.ToString();
    }

    public int GetMoneyCount(){
        Debug.Log("Money count:" + int.Parse(moneyText.text));
        return int.Parse(moneyText.text);
    }

}
