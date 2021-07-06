using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowScore : MonoBehaviour
{
    // Giving the Yellow cube the score for 20 points.
    void OnTriggerEnter(){
        ModeScore.CurrentScore += 20;
        gameObject.SetActive(false);
    }
}
