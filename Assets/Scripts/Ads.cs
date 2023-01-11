using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class Ads : MonoBehaviour
{
    public static Ads instance;
    public string gameID = "3366775";
    private const string rewardedVideo = "rewardedVideo";

    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        Advertisement.Initialize(gameID,true);
    }

    public void CallAdCoroutine(bool isAdRewarded,ShowOptions options)
    {
        StartCoroutine(WatchAd(isAdRewarded, options));
    }

    private IEnumerator WatchAd(bool isAdRewarded, ShowOptions options)
    {
        string videoId = "";
        if (isAdRewarded)
            videoId = rewardedVideo;
        int i = 0;
        while (i < 10)
        {
            i++;
            if (Advertisement.IsReady(videoId))
            {
                Advertisement.Show(videoId, options);
                yield break;
            }
            yield return new WaitForSecondsRealtime(0.25f);
        }
        options.resultCallback.Invoke(ShowResult.Failed);
    }

    public void interstitialAd()
    {
        if (Advertisement.IsReady("interstitialAd"))
        {
            Advertisement.Show("interstitialAd");
        }
    }

}