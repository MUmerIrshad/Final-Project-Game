using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestinationPoint : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // if destination Point Collide with player Show Level Complete, Remove Destiantion Message, Restart Button and stop Game
        if(other.gameObject.tag == "player")
        {
            GamePlayManager.gamePlayManager.levelComplete.SetActive(true);
            GamePlayManager.gamePlayManager.destinationMessage.SetActive(false);
            GamePlayManager.gamePlayManager.restartButton.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
