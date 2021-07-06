using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfPointTrigger : MonoBehaviour
{
    // This script checks if the car passes the half point trigger.
    public GameObject LapCompleteTrig;
    public GameObject HalfLapTrig;

    void OnTriggerEnter(){
        LapCompleteTrig.SetActive(true);
        HalfLapTrig.SetActive(false);
    }
}
