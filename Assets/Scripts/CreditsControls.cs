using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CreditsControls : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI buttonText;
    [SerializeField] TextMeshProUGUI displayText;

    private string currentButtonText;

    // Start is called before the first frame update
    void Start()
    {
        currentButtonText = "CREDITS";
    }

    public void TextChange(){
        if(currentButtonText == "CREDITS"){
            displayText.text = @"Credits:
Created by Andrew Mullan

Music by Eric Matyas
www.soundimage.org

Sounds from freesound:
Pickup_02.wav by LittleRobotSoundFactory
Explosion_03.wav by LittleRobotSoundFactory";
            currentButtonText = "CONTROLS";
            buttonText.text = "CONTROLS";
        } else {
            displayText.text = @"W: Move up
S: Move down
A: Move left
D: Move right

Avoid red circle enemies

Run into x1,x2,x3 to create an explosion to kill red enemies";
            currentButtonText = "CREDITS";
            buttonText.text = "CREDITS";
        }
    }

    public void QuitGame(){
        Application.Quit();
    }
}
