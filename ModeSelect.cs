using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeSelect : MonoBehaviour
{
    // This script contains different game modes.
    //0 = Race, 1 = Score, 2 = Time.

    public static int RaceMode;
    public GameObject TrackSelect;

    public void ScoreMode(){ // Allocating the buttons to different game modes.
        RaceMode = 1;
        TrackSelect.SetActive(true);
    }

    public void TimeMode(){
        RaceMode = 2;
        TrackSelect.SetActive(true);
    }

    public void TheRaceMode(){
        RaceMode = 0;
        TrackSelect.SetActive(true);
    }
}
