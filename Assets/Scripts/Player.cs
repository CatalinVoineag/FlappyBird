using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private bool jumpKeyPressed;
    private Rigidbody2D rigidBodyComponent;
    private static Player instance;


    public void Freeze()
    {
        
        rigidBodyComponent.constraints = RigidbodyConstraints2D.FreezeAll;
    }

    public void UnFreeze()
    {
        rigidBodyComponent.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    void Awake()
    {
        Debug.Log("AWAKE");
        rigidBodyComponent = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        Debug.Log(GetComponent<Rigidbody2D>());
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

    private void OnTriggerEnter2D(Collider2D objectColidingWith)
    {
         if (objectColidingWith.tag == "Pipe") {
             Destroy(gameObject);
             
         }
    }
}
