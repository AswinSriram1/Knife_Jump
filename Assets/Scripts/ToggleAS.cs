using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleAS : MonoBehaviour
{
    [SerializeField] GameObject oNImage;
    //[SerializeField] GameObject audioComponent;
    [SerializeField] GameObject oFFImage;

    public int counter ;
    

    /// <summary>
    /// ////////////////////////////////////////////////////////////////
    /// </summary>
    /// 
    private void Start()
    {
        
        counter = PlayerPrefs.GetInt("num");
        Activeknow();
    }
    void Activeknow()
    {
        if (counter % 2 == 1)
        {
            oNImage.SetActive(true);
            oFFImage.SetActive(false);
            //audioComponent.SetActive(true);
            Music.instance.SetTrue();
        }
        else
        {
            oNImage.SetActive(false);
            oFFImage.SetActive(true);
            //audioComponent.SetActive(false);
            Music.instance.SetFalse();
        }
        if (counter > 10)
        {
            counter = 1;
        }
    }
    public void onclick()
    {
        counter++;
        if (counter % 2 == 1)
        {
            oNImage.SetActive(true);
            oFFImage.SetActive(false);
            //audioComponent.SetActive(true);
            Music.instance.SetTrue();

        }
        else
        {
            oNImage.SetActive(false);
            oFFImage.SetActive(true);
            //audioComponent.SetActive(false);
            Music.instance.SetFalse();
        }
        if (counter > 10)
        {
            counter = 1;
        }
        PlayerPrefs.SetInt("num", counter);
    }
    
}
