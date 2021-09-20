using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddAttempts : Restart
{
    private void OnMouseDown()
    {
        attemptsLeftCounter += 10;
        PlayerPrefs.SetInt("Attempts", attemptsLeftCounter);
        
    }
}
