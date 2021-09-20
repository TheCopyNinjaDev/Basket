using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Back : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
