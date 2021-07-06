using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockedObject : MonoBehaviour
{
    // Creating the script to make the locked car unlockable permanent.
    public int greenSelect;
    public GameObject fakeGreen;

    void Start()
    {
        greenSelect = PlayerPrefs.GetInt("GreenBought");

        if(greenSelect == 100){
            fakeGreen.SetActive(false);
        }    
    }
}
