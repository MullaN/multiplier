using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Scoring : MonoBehaviour
{
    [SerializeField] int score;
    [SerializeField] TextMeshProUGUI scoreText;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    public void AddToScore(int multiplier){
        score += multiplier;
        scoreText.text = score.ToString();
    }

    public void GameOver(){
        PlayerPrefs.SetInt("player_score", score);
        SceneManager.LoadScene("GameOver");
    }
}
