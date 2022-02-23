using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TakePhoto : MonoBehaviour
{
    public Button takePhotoBtn;
    public GameObject takePhotoBtnObj;
    public EnergyBar energyBar;
    // public GameObject doneBtn;
    public GameObject checklist3;

	void Start () {
		Button btn = takePhotoBtn.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
        checklist3.SetActive(false);
	}

	void TaskOnClick(){
        energyBar.SetEnergy(energyBar.GetEnergy() - 3);
        takePhotoBtnObj.SetActive(false);
        checklist3.SetActive(true);
    }
}
