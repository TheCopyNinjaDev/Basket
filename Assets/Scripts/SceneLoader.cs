using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public int lvl;

    private int checker;

    private void OnMouseDown()
    {
        checker = PlayerPrefs.GetInt("LEVELtoUnlock");
        if (lvl > checker)
        {
            PlayerPrefs.SetInt("LEVELtoUnlock", lvl);
        }
       
        SceneManager.LoadScene("LVL" + lvl);
    }
}
