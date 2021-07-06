using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ButtonOption : MonoBehaviour
{
    // Allocating buttons.
    //public void PlayGame(){
    //    SceneManager.LoadScene(2);
    //}

    public void PlayGame(){
        SceneManager.LoadScene(1);
    }

    public void MainMenu(){
        SceneManager.LoadScene(0);
    }

    // Below here are track selections buttons.

    public void Track01(){
        SceneManager.LoadScene(2);
    }

    public void Track02(){
        SceneManager.LoadScene(3);
    }

    public void CreditScene(){
        SceneManager.LoadScene(4);
    }

}
