using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ModeScore : MonoBehaviour
{
    // This script contains a game mode called score game which when selected truns off the other game mode.
    public int ModeSelection;
    public GameObject RaceUI;
    public GameObject ScoreUI;

    public GameObject AICar;
    public static int CurrentScore;
    public int InternalScore;

    public GameObject ScoreValue;
    public GameObject ScoreObejcts;

    void Start()
    {
        ModeSelection = ModeSelect.RaceMode;
        
        if(ModeSelection == 1){ // Since this is score mode the Race time and AI car will be disabled.
            RaceUI.SetActive(false);
            ScoreUI.SetActive(true);
            AICar.SetActive(false);
            ScoreObejcts.SetActive(true);
        }
    }
    
    // Initialising the score value.
    void Update()
    {
        InternalScore = CurrentScore;
        ScoreValue.GetComponent<Text>().text = "" + InternalScore;
    }

}
