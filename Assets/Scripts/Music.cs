using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    public static Music instance;

    //public GameObject onImage;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    /*private void Update()
    {
        if(onImage.gameObject.activeSelf == false)
        {
            this.gameObject.SetActive(false);
        }
        else
        {
            this.gameObject.SetActive(true);
        }
    }*/
    public void SetTrue()
    {
        gameObject.SetActive(true);
    }
    public void SetFalse()
    {
        gameObject.SetActive(false);
    }
}
