using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Rigidbody2D rb;
    public Rigidbody2D hook;

    public GameObject RestartButton;

    public float releaseTime = .15f;
    public float maxDragDistance = 2f;

    private bool isPressed = false;

    public static Vector3 firstPos;

    private void Start()
    {
        firstPos = gameObject.transform.position;
    }

    void Update()
    {
        //Когда на мячике палец, он следует пальцу, но в определенном радиусе
        if (isPressed)
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (Vector3.Distance(mousePos, hook.position) > maxDragDistance)
                rb.position = hook.position - (hook.position - mousePos).normalized * maxDragDistance;
            else
                rb.position = mousePos; 
        }
    }

    void OnMouseDown()
    {
        isPressed = true;
        rb.isKinematic = true;
    }

    void OnMouseUp()
    {
        isPressed = false;
        rb.isKinematic = false;

        StartCoroutine(Release());
    }

    //Отсчитывает, когда мячик отпускать от нитки
    IEnumerator Release()
    {
        yield return new WaitForSeconds(releaseTime);

        GetComponent<SpringJoint2D>().enabled = false;

        RestartButton.SetActive(true);

        this.enabled = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameObject.GetComponent<AudioSource>().Play();
    }
}
