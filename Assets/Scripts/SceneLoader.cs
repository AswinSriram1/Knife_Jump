using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadingScene()
    {
        Vibration.Vibrate(23);
        SceneManager.LoadScene(0);
    }

    public void LoadFirst()
    {
        SceneManager.LoadScene(1);
    }
    public void LoadGame()
    {
        Vibration.Vibrate(23);
        SceneManager.LoadScene(2);
    }
    public void BaloonSelectMenu()
    {
        Vibration.Vibrate(23);
        SceneManager.LoadScene(3);
    }

    public void Quit()
    {
        Vibration.Vibrate(23);
        Application.Quit();
    }
}
