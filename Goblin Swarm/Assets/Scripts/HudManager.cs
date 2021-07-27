using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class HudManager : MonoBehaviour
{
    //Initializing variables
    public Text goblinKillText;
    string scoreFormat = "0#";
    public int goblinKills;
    float timeToDisplay;
    float minutes;
    float seconds;


    // Start is called before the first frame update
    private void Update()
    {
        UpdateHud();
    }

    void UpdateHud()
    {
        //Storing the text for hud
        goblinKillText.text = "Score: " + goblinKills.ToString(scoreFormat);

    }

    public void IncreaseScore()
    {
        goblinKills++;
        UpdateHud();
    }
}
