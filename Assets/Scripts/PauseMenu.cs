using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class PauseMenu : PauseGame
{

    public GameObject PauseMenuUI;

    protected static bool muted = false;

    private void Awake()
    {
        muted = (PlayerPrefs.GetInt("Muted") != 0);
    }

    private void Update()
    {
        if (!PauseButton.activeSelf)
        {
            Pause();
            MuteSave();
        }
        else Resume();   
    }

    public void Resume()
    {
        PauseButton.SetActive(true);
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
    }

    void Pause()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
    }

    public void ChooseLevel()
    {
        SceneManager.LoadScene("LVLSwitcher");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Mute()
    {
        muted = !muted;
        PlayerPrefs.SetInt("Muted", muted ? 1 : 0);
    }
    void MuteSave()
    {
        //Mute thing
        if (!muted)
        {
            GameObject.Find("MuteButton").GetComponentInChildren<Text>().text = "Sound: on";
        }
        else
        {
            GameObject.Find("MuteButton").GetComponentInChildren<Text>().text = "Sound: off";
        }
    }
}
