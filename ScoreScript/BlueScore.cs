using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueScore : MonoBehaviour
{
    // Giving the blue cube the score for 50 points.
    void OnTriggerEnter(){
        ModeScore.CurrentScore += 50;
        gameObject.SetActive(false);
    }
}
