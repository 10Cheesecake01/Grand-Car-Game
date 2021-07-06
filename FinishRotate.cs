using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishRotate : MonoBehaviour
{
    // Rotating the camera around the car once the player finish the game as a celebration.
    void Update()
    {
        transform.Rotate(0, 2, 0, Space.World);
    }
}
