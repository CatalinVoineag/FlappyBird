using UnityEngine;

public class BirdNeutralState : BirdBaseSate
{
    public override void EnterState(GameManager gameManager)
    {
        gameManager.rigidBodyComponent.constraints = RigidbodyConstraints2D.FreezeAll;
    }
    public override void UpdateState(GameManager gameManager)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            gameManager.SwitchState(gameManager.birdFlyingState);
        }
    }
    public override void OnCollisionEnter(GameManager gameManager)
    {

    }
}