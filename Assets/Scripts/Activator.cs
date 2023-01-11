using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activator : MonoBehaviour
{
    [SerializeField] GameObject rightSpawner;
    [SerializeField] GameObject allDirectionSpawn;
    [SerializeField] GameObject rightShower;
    [SerializeField] GameObject directionShower;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("RightShower",22);
        Invoke("ActivateRight",25);
        Invoke("DirectionShower",32);
        Invoke("ActivateAllDirection", 35);
    }

    public void RightShower()
    {
        rightShower.SetActive(true);
    }
    public void ActivateRight()
    {
        rightSpawner.SetActive(true);
    }
    public void DirectionShower()
    {
        rightShower.SetActive(false);
        directionShower.SetActive(true);
    }
    public void ActivateAllDirection()
    {
        //directionShower.SetActive(false);
        allDirectionSpawn.SetActive(true);
    }
}

