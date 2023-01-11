using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;



public class AdController : MonoBehaviour
{
    private void Start()
    {
        
    }

    public void watchAdsControll1()
    {
        ShowOptions options1 = new ShowOptions();
        options1.resultCallback = watchAdsAccess1;
        //ShowOptions options1 = options1.resultCallback. watchAdsAccess1;
        Ads.instance.CallAdCoroutine(true, options1);
    }

    private void watchAdsAccess1(ShowResult result)
    {
        if (result == ShowResult.Finished)
        {
            shopUI.watch1 = 2;
            PlayerPrefs.SetInt("watch1", shopUI.watch1);
            //Particals.instance.particlesPlay();
        }
    }

    public void watchAdsControll2()
    {
        ShowOptions options2 = new ShowOptions();
        options2.resultCallback = watchAdsAccess2;
        Ads.instance.CallAdCoroutine(true, options2);
    }

    private void watchAdsAccess2(ShowResult result)
    {
        if (result == ShowResult.Finished)
        {
            shopUI.watch2 = 2;
            PlayerPrefs.SetInt("watch2", shopUI.watch2);
            
        }
    }

    public void watchAdsControll3()
    {
        ShowOptions options3 = new ShowOptions();
        options3.resultCallback = watchAdsAccess3;
        Ads.instance.CallAdCoroutine(true, options3);
    }

    private void watchAdsAccess3(ShowResult result)
    {
        if (result == ShowResult.Finished)
        {
            shopUI.watch3 = 2;
            PlayerPrefs.SetInt("watch3", shopUI.watch3);
        }
    }

}
