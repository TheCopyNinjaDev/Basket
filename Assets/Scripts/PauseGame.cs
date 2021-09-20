using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    public GameObject PauseButton;

    private void OnMouseDown()
    {
        PauseButton.SetActive(false);
    }
}
