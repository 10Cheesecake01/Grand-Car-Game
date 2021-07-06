using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalCash : MonoBehaviour
{
    // Creating Cash and making it update every time we finish the game.
    public int CashValue;
    public static int TotalCash;
    public GameObject CashDisplay;

    void Start()
    {
        TotalCash = PlayerPrefs.GetInt("SavedCash");
    }

    
    void Update()
    {
        CashValue = TotalCash;
        CashDisplay.GetComponent<Text>().text = "Cash $ " + CashValue;
    }
}
