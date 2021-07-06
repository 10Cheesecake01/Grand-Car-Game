using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalCar : MonoBehaviour
{
    // This script allows the player to select a color for the car. 
    // 1 = red, 2 = blue, 3 = green. Adding selection of car color.
    
    public static int CarType; 
    public GameObject TrackWindow;

    public void RedCar(){
        CarType = 1;
        TrackWindow.SetActive(true);
    }

    public void BlueCar(){
        CarType = 2;
        TrackWindow.SetActive(true);
    }

    public void GreenCar(){
        CarType = 3;
        TrackWindow.SetActive(true);
    }
}
