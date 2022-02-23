using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CheckLighting : MonoBehaviour
{
    public Button checkLightingBtn;
    public GameObject checkLightingBtnObj;
    public GameObject setupTripodBtn;
    public EnergyBar energyBar;
    public GameObject checklist1;

	void Start () {
		Button btn = checkLightingBtn.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
        setupTripodBtn.SetActive(false);
        checklist1.SetActive(false);
	}

	void TaskOnClick(){
        energyBar.SetEnergy(energyBar.GetEnergy() - 3);
        checkLightingBtnObj.SetActive(false);
        setupTripodBtn.SetActive(true);
        checklist1.SetActive(true);
    }
}
