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
    public GameObject checklist0;
    public AudioSource audio;

	void Start () {
		Button btn = checkLightingBtn.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
        setupTripodBtn.SetActive(false);
        checklist1.SetActive(false);
	}

	void TaskOnClick(){
        audio.Play();
        energyBar.SetEnergy(energyBar.GetEnergy() - 1);
        checkLightingBtnObj.SetActive(false);
        setupTripodBtn.SetActive(true);
        checklist1.SetActive(true);
        checklist0.SetActive(false);
    }
}
