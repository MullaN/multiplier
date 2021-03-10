using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HighScores : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI currentScore;
    // Start is called before the first frame update
    void Start()
    {
        currentScore.text += " " + PlayerPrefs.GetInt("player_score").ToString();        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
