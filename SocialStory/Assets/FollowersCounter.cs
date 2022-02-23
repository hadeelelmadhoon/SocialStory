using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FollowersCounter : MonoBehaviour
{
    public Text followersText;

    public void SetFollowersCount(int followers){
        followersText.text = followers.ToString();
    }

    public int GetFollowersCount(){
        Debug.Log("Followers count:" + int.Parse(followersText.text));
        return int.Parse(followersText.text);
    }
}
