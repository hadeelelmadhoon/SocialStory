using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CreateContent : MonoBehaviour {
	public Button createContentBtn;
    public EnergyBar energyBar;
    public MoneyCounter moneyCounter;

	void Start () {
		Button btn = createContentBtn.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);

	}

    bool hasEnergy(int neededEnergy){
        int remainingEnergy = energyBar.GetEnergy() - neededEnergy;
        if(remainingEnergy < 0){
            return false;
        } else{
            return true;
        }
    }

	void TaskOnClick(){
        if(hasEnergy(3)){
            energyBar.SetEnergy(energyBar.GetEnergy() - 3);
            moneyCounter.SetMoneyCount(moneyCounter.GetMoneyCount() + 50);
        }
        else{
            Debug.Log("You don't have enough energy");
        }
	}
}