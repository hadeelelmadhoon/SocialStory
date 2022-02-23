using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SetupTripod : MonoBehaviour
{
    public Button setupTripodBtn;
    public GameObject setupTripodBtnObj;
    public GameObject tripod;
    public EnergyBar energyBar;
    public GameObject takePhotoBtn;
    public GameObject checklist2;

	void Start () {
		Button btn = setupTripodBtn.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
        tripod.SetActive(false);
        takePhotoBtn.SetActive(false);
        checklist2.SetActive(false);
	}

	void TaskOnClick(){
        energyBar.SetEnergy(energyBar.GetEnergy() - 3);
        tripod.SetActive(true);
        setupTripodBtnObj.SetActive(false);
        takePhotoBtn.SetActive(true);
        checklist2.SetActive(true);
    }
}
