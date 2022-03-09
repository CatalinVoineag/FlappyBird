using UnityEngine;

public class BirdFlyingState : BirdBaseSate
{
    public override void EnterState(GameManager gameManager)
    {
        Debug.Log("FLYING");
        gameManager.Find("Player").GetComponent<Rigidbody2D>.constraints = RigidbodyConstraints2D.FreezeRotation;
    }
    public override void UpdateState(GameManager gameManager)
    {

    }
    public override void OnCollisionEnter(GameManager gameManager)
    {

    }
}