using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CreateContent : MonoBehaviour {
	public Button createContentBtn;
    public GameObject createContentBtnObject;
    public EnergyBar energyBar;
    public MoneyCounter moneyCounter;
    public GameObject checkLightingBtn;
    public GameObject checklist0;
    public GameObject energyError;
    public AudioSource buttonAudio;
    public AudioSource errorAudio;

	void Start () {
		Button btn = createContentBtn.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
        checkLightingBtn.SetActive(false);
        checklist0.SetActive(false);
        energyError.SetActive(false);
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
        if(hasEnergy(6)){
            buttonAudio.Play();
            // energyBar.SetEnergy(energyBar.GetEnergy() - 3);
            // moneyCounter.SetMoneyCount(moneyCounter.GetMoneyCount() + 50);
            createContentBtnObject.SetActive(false);
            checkLightingBtn.SetActive(true);
            checklist0.SetActive(true);
        }
        else{
            energyError.SetActive(true);
            errorAudio.Play();
            Debug.Log("You don't have enough energy");
        }
	}
}