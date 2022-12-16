using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerMovement : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 8f;
    public float gravity = -9.8f;
    public float jumphight = 3f;
    public Transform groundcheak;
    public float grounddistance = 0.4f;
    public LayerMask groundmask;
    public Vector3 velocity;
    bool grounded;

    // Update is called once per frame
    void Update()
    {
        // cheak the player is Grounded
        grounded = Physics.CheckSphere(groundcheak.position, grounddistance, groundmask);
        if (grounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }
        // taking the  input Horizontal and Verticle
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        //transform.Translate(Vector3.right * x * Time.deltaTime * speed);
        //transform.Translate(Vector3.forward * z * Time.deltaTime * speed);
        // move player in X and Z Direction and Move with that speed
        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);
        // if Player is Grounded  and Get Input Jump then move player to Y direction with veclocity
        if (Input.GetButtonDown("Jump") && grounded)
        {
            velocity.y = Mathf.Sqrt(jumphight * -2f * gravity);
        }
        // Adding veclocity to move controller and Gravity
        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);

    }
}
  