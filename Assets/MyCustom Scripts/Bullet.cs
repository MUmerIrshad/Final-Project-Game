using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float life = 5f;
    private void Awake()
    {
        // Destroy bullet after %f
        Destroy(gameObject, life);

    }
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "player")
        {
            // if bullet Collide with Player then maximum health which is 100. then -20 to 100 and divided it by 100 and filled it in life of player
            // it means if player short 6 bullets player will die amd Bullet is destroy
            GamePlayManager.gamePlayManager.currentHealth = GamePlayManager.gamePlayManager.maxEnemyHealth - 20;
            GamePlayManager.gamePlayManager.maxEnemyHealth = GamePlayManager.gamePlayManager.currentHealth;
            GamePlayManager.gamePlayManager.EnemyFilledHealthBar.fillAmount = GamePlayManager.gamePlayManager.currentHealth / 100;
            if (GamePlayManager.gamePlayManager.EnemyFilledHealthBar.fillAmount <= 0)
            {
                Destroy(GamePlayManager.gamePlayManager.Player);
                GamePlayManager.gamePlayManager.camer.SetActive(true);
                GamePlayManager.gamePlayManager.levelFailed.SetActive(true);
                GamePlayManager.gamePlayManager.restartButton.SetActive(true);
                GamePlayManager.gamePlayManager.destinationMessage.SetActive(false);
            }
            Destroy(gameObject);
           
        }
        if (collision.gameObject.tag == "Enemy")
        {
            // if Collide with enemy kill the enemy and bullet
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
