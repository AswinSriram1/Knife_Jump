using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdsForLosing : MonoBehaviour
{
    public static AdsForLosing instance;

    [SerializeField] private int timesToLose = 4;

    private const string gamesInARowLost = "gamesInARowLost";

    private void Awake()
    {
        instance = this;
    }

    public void CalculatingScene()
    {
        int gamesLost = PlayerPrefs.GetInt(gamesInARowLost) + 1;
        PlayerPrefs.SetInt(gamesInARowLost, gamesLost);
        if (gamesLost >= timesToLose)
        {
            PlayerPrefs.SetInt(gamesInARowLost, 0);
            VideoAd();           
        }
        
    }

    private void VideoAd()
    {
        if (Advertisement.IsReady("video"))
        {
            Advertisement.Show("video");
        }

        
    }

    

}
