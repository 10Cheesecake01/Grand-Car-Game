using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedScore : MonoBehaviour
{
    // Giving the red cube the score for 100 points.
    void OnTriggerEnter(){
        ModeScore.CurrentScore += 100;
        gameObject.SetActive(false);
    }
}
