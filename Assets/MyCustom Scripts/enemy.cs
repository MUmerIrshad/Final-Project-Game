using UnityEngine;

public class enemy : MonoBehaviour
{
    private float dist;
    public float firerate;
    private float nextfire = 0f;
    public GameObject bulletprefab;
    private Animator enemyAnimation;

    public Transform bulletspawnpoint;
    public float bulletspeed = 10;
    public float HowClose;


    // Start is called before the first frame update
    void Start()
    {
        // Getting Animator Component for animation 
        enemyAnimation = GetComponent<Animator>();
    }
    void Update()
    {
        // if total distance from player to enemy is less then selected valve look towards the player
        dist = Vector3.Distance(GamePlayManager.gamePlayManager.Player.transform.position, transform.position);
        if (dist <= HowClose)
        {
            transform.LookAt(GamePlayManager.gamePlayManager.Player.transform);
        }
        // if distance is closer and bullet is not fired Recently then fire the bullet and start firing Animation
        if (dist <= HowClose && Time.time > nextfire)
        {
            nextfire = Time.time + firerate;
            enemyAnimation.SetBool("Fire_onPlayer", true);
            var bullet = Instantiate(bulletprefab, bulletspawnpoint.position, bulletspawnpoint.rotation);
            bullet.GetComponent<Rigidbody>().AddForce(bulletspawnpoint.forward * bulletspeed);
        }
    }


}