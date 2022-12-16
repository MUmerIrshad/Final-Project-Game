using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GamePlayManager : MonoBehaviour
{
    [Header("Enemy Health Bar")]
    public float maxEnemyHealth = 100;
    public float currentHealth = 100;
    public Image EnemyFilledHealthBar;
    public GameObject resumeButton;
    public GameObject restartButton;
    public GameObject destinationMessage;
    public GameObject Player;
    public GameObject camer;
    public GameObject levelFailed;
    public GameObject levelComplete;
    private AudioSource HittingBullets;

    public static GamePlayManager gamePlayManager;

    private void Awake()
    {
        if (gamePlayManager == null)
        {
            gamePlayManager = this;
        }
    }
    void Start()
    {
        // if in the Play mode cursor will lock and get audio of Hitting bullet 
        //Cursor.lockState = CursorLockMode.Locked;
        HittingBullets = GetComponent<AudioSource>();
    }
    // if clicking game pause then stop gameand show resume and restart Button
    public void gamepause()
    {
        Time.timeScale = 0;
        resumeButton.SetActive(true);
        restartButton.SetActive(true);

    }
    // if clicking game Resume then play game and disable resume and restart Button
    public void gameresume()
    {
        Time.timeScale = 1;
        resumeButton.SetActive(false);
        restartButton.SetActive(false);

    }
    // if clicking on restart then play game and load again scene
    public void restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Gameplay");
    }
}
