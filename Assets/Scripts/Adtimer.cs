using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class Adtimer : MonoBehaviour
{
    [SerializeField] float AdTime;
 
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(callAD());
    }

    IEnumerator callAD()
    {
        yield return new WaitForSeconds(AdTime);

        if (Advertisement.IsReady())
        {
            Advertisement.Show();
        }
    }
}

