using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public Sprite none;
    private GameObject Ball;

    private void Start()
    {
        Ball = GameObject.Find("Ball");
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            Ball.GetComponent<AudioSource>().enabled = false;
            if (Ball.GetComponent<SpriteRenderer>().sprite != none) gameObject.GetComponent<AudioSource>().Play();
            Ball.GetComponent<SpriteRenderer>().sprite = none;
            Ball.GetComponentInChildren<ParticleSystem>().Play();
        }
        
    }
}
