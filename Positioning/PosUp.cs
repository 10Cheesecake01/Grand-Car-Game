using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PosUp : MonoBehaviour
{
    // Creating this script to check the position of the race car. Either 1st or 2nd place.
    // In this case we are checking if it's in 1st place.
    public GameObject positionDisplay;

    void OnTriggerExit(Collider other){
        if(other.tag == "CarPos"){
            positionDisplay.GetComponent<Text>().text = "1st Place";
        }
    }

}
