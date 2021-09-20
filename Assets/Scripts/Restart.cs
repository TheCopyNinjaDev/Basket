using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public static int attemptsLeftCounter = 5;

    public Sprite ball;

    private GameObject Ball;


    private void Start()
    {
        attemptsLeftCounter = PlayerPrefs.GetInt("Attempts");
        
        PlayerPrefs.SetInt("Attempts", attemptsLeftCounter);
        Ball = GameObject.Find("Ball");
    }

    private void OnMouseDown()
    {
        //Уменьшение количества оставшихся попыток
        if (attemptsLeftCounter > 0)
        {
            attemptsLeftCounter = PlayerPrefs.GetInt("Attempts");
            attemptsLeftCounter--;
            PlayerPrefs.SetInt("Attempts", attemptsLeftCounter);
        }
        else attemptsLeftCounter = 0;

        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Ball.GetComponent<SpriteRenderer>().sprite = ball;
        Ball.transform.position = BallController.firstPos;
        Ball.GetComponent<SpringJoint2D>().enabled = true;
        Ball.GetComponent<BallController>().enabled = true;
        Ball.GetComponent<AudioSource>().enabled = true;
        gameObject.SetActive(false);
    }
}
