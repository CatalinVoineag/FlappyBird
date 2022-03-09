using UnityEngine;
public abstract class BirdBaseSate
{
    public abstract void EnterState(GameManager gameManager);
    public abstract void UpdateState(GameManager gameManager);
    public abstract void OnCollisionEnter(GameManager gameManager);
}