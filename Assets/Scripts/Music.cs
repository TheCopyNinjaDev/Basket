using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine;

public class Music : MonoBehaviour
{
    private bool muted;

    private void Update()
    {
        muted = (PlayerPrefs.GetInt("Muted") != 0);

        if (muted)
        {
            AudioListener.volume = 0;
        }else AudioListener.volume = 1;
    }
}
