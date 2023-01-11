using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGSelect : MonoBehaviour
{
    private GameObject[] BG;
    int index;

    // Start is called before the first frame update
    void Start()
    {
        index = PlayerPrefs.GetInt("BGIndex");
        BG = new GameObject[transform.childCount];
        for (int i = 0; i < transform.childCount; i++)
            BG[i] = transform.GetChild(i).gameObject;
        foreach (GameObject go in BG)
            go.SetActive(false);
        if (BG[index])
            BG[index].SetActive(true);

    }

    public void Change()
    {
        BG[index].SetActive(false);
        index++;
        if (index == BG.Length)
            index = 0;
        BG[index].SetActive(true);
        PlayerPrefs.SetInt("BGIndex", index);
    }
}
