using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockLvLs : SceneLoader
{
    public Sprite unlockedSprite;
    public GameObject Icon;

    public int lvlNumber;

    private int unlocker;
 
    private void Start()
    {
        unlocker = PlayerPrefs.GetInt("LEVELtoUnlock");
        if (unlocker >= lvlNumber)
        {
            Icon.GetComponent<SpriteRenderer>().sprite = unlockedSprite;
        }
    }
}
