using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject pipe;
    public GameObject player;
    private Player playerScript;
    private Pipe pipeScript;
    public Rigidbody2D rigidBodyComponent {get; set;}

    BirdBaseSate currentSate;
    public BirdNeutralState birdNeutralState = new BirdNeutralState();
    public BirdFlyingState birdFlyingState = new BirdFlyingState();

    void Start()
    {
        rigidBodyComponent = GetComponent<Rigidbody2D>();
        currentSate = birdNeutralState;
        currentSate.EnterState(this);
    }

    void Update()
    {
        currentSate.UpdateState(this);
    }

    public void SwitchState(BirdBaseSate state){
        currentSate = state;
        state.EnterState(this);
    }
}
