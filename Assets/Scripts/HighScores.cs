using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HighScores : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI currentScoreText;
    [SerializeField] TextMeshProUGUI highScoreText;
    [SerializeField] TextMeshProUGUI newHighScoreText;
    // Start is called before the first frame update
    void Start()
    {
        int score = PlayerPrefs.GetInt("player_score");
        if (!PlayerPrefs.HasKey("high_score")){
            PlayerPrefs.SetInt("high_score", score);
            newHighScoreText.text = "New High Score!";
        }
        else if (score > PlayerPrefs.GetInt("high_score")){
            PlayerPrefs.SetInt("high_score", score);
            newHighScoreText.text = "New High Score!";
        }
        currentScoreText.text += " " + score.ToString();
        highScoreText.text += " " + PlayerPrefs.GetInt("high_score").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
