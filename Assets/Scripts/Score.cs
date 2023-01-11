using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public static Score instance;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI GameoverScore;
    public TextMeshProUGUI highScoreText;
    public float ScoreAmount;

    public float PointsIncreasePerSecond;
    public bool dead;
    float highScore;
    float noting;

    // Start is called before the first frame update
    private void Awake()
    {
        
            instance = this;
        
    }
    void Start()
    {
        ScoreAmount = 0f;
        PointsIncreasePerSecond = 20f;
        dead = false;
        highScore = 0;
        highScore = PlayerPrefs.GetFloat("highScore", highScore);
    }

    // Update is called once per frame
    void Update()
    {
        if(dead == true)
        {
            //HighScore();
            return;
        }
        scoreText.text = (int)ScoreAmount + "";
        GameoverScore.text = (int)ScoreAmount + "";
        highScoreText.text = PlayerPrefs.GetFloat("highScore", highScore).ToString();
        ScoreAmount += PointsIncreasePerSecond * Time.deltaTime;
        
        if (PlayerPrefs.GetFloat("highScore", highScore) < ScoreAmount)
        {
            //highScore = ScoreAmount;
            highScoreText.text = PlayerPrefs.GetFloat("highScore", ScoreAmount).ToString();
            PlayerPrefs.SetFloat("highScore", ScoreAmount);

        }
    }
    /*void HighScore()
    {
        noting = ScoreAmount;
        if (noting > highScore)
        {
            highScore = ScoreAmount;
            highScoreText.text = highScore.ToString();
            PlayerPrefs.SetFloat("highScore", highScore);
        }
    }*/
}

