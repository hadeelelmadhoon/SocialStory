using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TakePhoto : MonoBehaviour
{
    public Button takePhotoBtn;
    public GameObject takePhotoBtnObj;
    public EnergyBar energyBar;
    public GameObject postPhotoBtn;
    public GameObject checklist3;
    public GameObject checklist2;
    public AudioSource audio;

	void Start () {
		Button btn = takePhotoBtn.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
        checklist3.SetActive(false);
        postPhotoBtn.SetActive(false);
	}

	void TaskOnClick(){
        audio.Play();
        energyBar.SetEnergy(energyBar.GetEnergy() - 2);
        takePhotoBtnObj.SetActive(false);
        checklist3.SetActive(true);
        checklist2.SetActive(false);
        postPhotoBtn.SetActive(true);
    }
}
