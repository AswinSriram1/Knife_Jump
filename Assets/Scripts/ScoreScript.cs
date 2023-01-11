using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public static int scoreValue = 0;
    Text score;
    [SerializeField] float scoreSpeed;
    PlayerJump playerJump;

    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
        playerJump = GetComponent<PlayerJump>();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Score" + scoreValue;
        scoreValue++;
        
    }
}
