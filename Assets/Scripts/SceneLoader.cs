using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadRulesScreen(){
        SceneManager.LoadScene("RulesSplash");
    }

    public void LoadStartScreen(){
        SceneManager.LoadScene("StartScreen");
    }
}
