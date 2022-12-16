using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class uiManager : MonoBehaviour
{
    [Header("Game Screens")]
    public GameObject levelselection;
    public GameObject Setting;
    public GameObject mainmenu;
    [Header("Mission Prefab")]
    public GameObject[] levels;
    // static class of UI
    public static uiManager uimanager;

    // if clicked on button level Selection menu is on and main menu is off
    public void level_selection()
    {
        levelselection.gameObject.SetActive(true);
        mainmenu.gameObject.SetActive(false);
    }
    // if clicked on button level Selection and main menu is off and setting is on
    public void setting()
    {
        Setting.gameObject.SetActive(true);
        mainmenu.gameObject.SetActive(false);
    }

    // if clicked on back it will cheak where are we level Selection and setting  then on main menu
    public void back()
    {
        if (levelselection && Setting)
        {
            mainmenu.gameObject.SetActive(true);
            Setting.gameObject.SetActive(false);
            levelselection.gameObject.SetActive(false);
        }
    }
    // load the scene 
    public void gamemission()
    {
        SceneManager.LoadScene("Gameplay");
    }

}