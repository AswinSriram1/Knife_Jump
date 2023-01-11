using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockActivation : MonoBehaviour
{
    [SerializeField] GameObject watchAdsButton;

    // Start is called before the first frame update
    void Start()
    {
        watchAdsButton.SetActive(true);
    }
    
}
