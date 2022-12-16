using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Transform bulletspawnpoint;
    public GameObject bulletprefab;
    public float bulletspeed = 10f;
    private AudioSource Bulletsound;
    public Camera mainCamera;

    private void Start()
    {
        Bulletsound = GetComponent<AudioSource>();
    }

    void Update()
    {
        // if click on right Click mouse button then play bullet Sound and spawn Bullet from Spawn Point  
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            Bulletsound.Play();
            var bullet = Instantiate(bulletprefab, bulletspawnpoint.position, bulletspawnpoint.rotation);
            bullet.GetComponent<Rigidbody>().velocity = bulletspawnpoint.forward * bulletspeed;
        }
        // if clicking on left mouse button Zoom in and Zoom Out.
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            if(mainCamera.fieldOfView == 60)
            {
                mainCamera.fieldOfView = 32;
            }
            else if(mainCamera.fieldOfView == 32)
            {
                mainCamera.fieldOfView = 60;
            }
        }
    }
}
