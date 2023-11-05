using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    PlayerMovement controls;
    private float speed = 200f;
    private float increment = 5;
    private float maxY = 5;
    private float minY = -5;
    private Vector2 targetPos;
    public GameObject moveEffect;
    public Animator camAnim;

    private bool isAlive = true; // Boolean flag to track player's alive status

    private void Awake()
    {
        controls = new PlayerMovement();
        controls.Enable();

        // Register the event outside of any update functions
        controls.floating.UPandDOWN.performed += ctx => MovePlayer(ctx.ReadValue<float>());
    }

    private void MovePlayer(float inputValue)
    {
        if (!isAlive) return; // Don't move the player if they are not alive

        // Calculate the new position based on the input value
        float newY = Mathf.Clamp(transform.position.y + increment * inputValue, minY, maxY);
        targetPos = new Vector2(transform.position.x, newY);
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
        camAnim.SetTrigger("shake");
        Instantiate(moveEffect, transform.position, Quaternion.identity);
    }

    public void DestroyPlayer()
    {
        isAlive = false; // Set the player's alive status to false when destroyed
        // Any other code related to destroying the player
    }

    void Start()
    {
        // Initialize targetPos with the starting position of the player
        targetPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // You can add any other necessary update logic here
    }
}
