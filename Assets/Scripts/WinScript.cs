using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScript : MonoBehaviour
{
    public float time = 10f;
    private bool timerDone = false;

    public GameObject Hit;
    public GameObject RestartButton;
    public GameObject NextButton;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        StartCoroutine(Timer());
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (timerDone == true)
        {
            Hit.SetActive(true);
            NextButton.SetActive(true);
            RestartButton.SetActive(false);
        }
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(time);
        timerDone = true;
    }
}
