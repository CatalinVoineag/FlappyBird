using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private bool jumpKeyPressed;
    private Rigidbody2D rigidBodyComponent;
    void Start()
    {
        rigidBodyComponent = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumpKeyPressed = true;
        }
    }
    // This is called once every physic update
    private void FixedUpdate()
    {
        if (jumpKeyPressed){
            rigidBodyComponent.AddForce(Vector2.up * 5, ForceMode2D.Impulse);
        }
        jumpKeyPressed = false;
    }
}
