using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ModeTime : MonoBehaviour
{
    // This script is for another game mode which does not invole the AI Car. Therefore we don't want the AI Car to be present in this particular game mode.
    public int ModeSelection;
    public GameObject AICar;
    public static bool isTimeMode = false;

    void Start()
    {
        ModeSelection = ModeSelect.RaceMode;
        
        if(ModeSelection == 2){ // Since this is Time mode the Race time and AI car will be disabled.
            isTimeMode = true;
            AICar.SetActive(false);
        }
    }
}
