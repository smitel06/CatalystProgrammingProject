using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(menuName = "AICondition/PressedSpaceCondition")]
public class MoveInDirection : AIBehaviour
{
    [SerializeField] private Vector3 _movementDirection;
    [SerializeField] private float _movementSpeed;

    //Moves the entity in one direction using transform.position
    public override void EnterState()
    {
        Debug.Log("Entered move in direction behaviour");
    }

    public override void RunBehaviour(float deltaTime)
    {
        _stateMachine.transform.position += _movementDirection * _movementSpeed * deltaTime;
    }

    public override void ExitState()
    {
        _stateMachine.transform.position = Vector3.zero;
        Debug.Log("Exited move in direction behaviour");
    }

    
}
