using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditFinish : MonoBehaviour
{
    // Once the credits are done the scene will move automatic to the main menu. 
    void Start()
    {
        StartCoroutine(CreditsEnd());
    }

    IEnumerator CreditsEnd(){
        yield return new WaitForSeconds(10);
        SceneManager.LoadScene(0);
    }

}
