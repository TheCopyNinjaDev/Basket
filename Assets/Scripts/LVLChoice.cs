using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LVLChoice : SceneLoader
{

    public GameObject lvlIcon;

    public int lvlNumber;

    private int unlocker;

    private void OnMouseDown()
    {
        unlocker = PlayerPrefs.GetInt("LEVELtoUnlock");
        if (unlocker >= lvlNumber)
        {
            SceneManager.LoadScene("LVL" + lvlIcon.name);
        }
        else if (lvlNumber == 1) SceneManager.LoadScene("LVL1");
    }
}
