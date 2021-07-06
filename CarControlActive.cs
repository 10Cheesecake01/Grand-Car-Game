using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;

public class CarControlActive : MonoBehaviour
{
    // Making sure that the player is able to control the car.
    public GameObject CarControl;
    public GameObject DreamCar01;

    void Start() {
        CarControl.GetComponent<CarController>().enabled = true;
        DreamCar01.GetComponent<CarAIControl>().enabled = true;
 }
 
}
