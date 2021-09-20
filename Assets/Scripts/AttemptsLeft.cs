using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttemptsLeft : Restart
{
    public Text attemptsLeftText;
    
    private void Update()
    {
        attemptsLeftText.text = "Attempts left: " + attemptsLeftCounter.ToString();
    }
}
