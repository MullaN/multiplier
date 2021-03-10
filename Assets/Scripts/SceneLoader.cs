using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadGameScreen(){
        SceneManager.LoadScene("MainGame");
    }

    public void LoadStartScreen(){
        SceneManager.LoadScene("StartScreen");
    }
}
