using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class RulesScript : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI rulesText;

    float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
            SceneManager.LoadScene("MainGame");
        }
        timer += Time.deltaTime;
        if (timer > 6f){
            SceneManager.LoadScene("MainGame");
        } else if (timer > 2f){
            rulesText.text = @"Run into 1x, 2x, or 3x to spawn an explosion that kills red enemies.
Points per enemy:
1x: 1 point
2x: 2 points
3x: 3 points";
        }
    }
}
