using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shopUI : MonoBehaviour
{
    public GameObject WatchAdsButton1;
    public GameObject WatchAdsButton2;
    public GameObject WatchAdsButton3;

    public static int watch1;
    public static int watch2;
    public static int watch3;

    // Start is called before the first frame update
    void Start()
    {
        watch1 = PlayerPrefs.GetInt("watch1", 1);
        watch2 = PlayerPrefs.GetInt("watch2", 1);
        watch3 = PlayerPrefs.GetInt("watch3", 1);
    }

    // Update is called once per frame
    void Update()
    {
        watchAds1();
        watchAds2();
        watchAds3();

    }

    public void watchAds1()
    {
        if (watch1 == 1)
        {
            WatchAdsButton1.SetActive(true);
        }
        if(watch1 == 2)
        {
            WatchAdsButton1.SetActive(false);
        }

    }

    public void watchAds2()
    {
        if (watch2 == 1)
        {
            WatchAdsButton2.SetActive(true);
        }
        if (watch3 == 2)
        {
            WatchAdsButton2.SetActive(false);
        }
    }

    public void watchAds3()
    {
        if (watch3 == 1)
        {
            WatchAdsButton3.SetActive(true);
        }
        if (watch3 == 2)
        {
            WatchAdsButton3.SetActive(false);
        }
    }

}
