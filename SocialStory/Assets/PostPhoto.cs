using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PostPhoto : MonoBehaviour
{
    public Button postPhotoBtn;
    public GameObject postPhotoBtnObj;
    public EnergyBar energyBar;
    public GameObject checklist3;
    public MoneyCounter moneyCounter;
    public GameObject tripod;
    public GameObject createContentBtn;
    public FollowersCounter followersCounter;
    public AudioSource audio;

	void Start () {
		Button btn = postPhotoBtn.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick(){
        audio.Play();
        energyBar.SetEnergy(energyBar.GetEnergy() - 1);
        moneyCounter.SetMoneyCount(moneyCounter.GetMoneyCount() + 50);
        followersCounter.SetFollowersCount(followersCounter.GetFollowersCount() + 100);
        postPhotoBtnObj.SetActive(false);
        checklist3.SetActive(false);
        tripod.SetActive(false);
        createContentBtn.SetActive(true);
    }
}
