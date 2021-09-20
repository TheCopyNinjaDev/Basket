using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ChooseLevel : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene("LVLSwitcher");
    }
}
