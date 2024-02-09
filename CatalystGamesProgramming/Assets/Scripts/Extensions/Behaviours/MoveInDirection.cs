using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class MoveInDirection : AIBehaviour
{
    [SerializeField] private Vector3 _movementDirection;
    [SerializeField] private float _movementSpeed;
    [SerializeField] private Transform _myTransform;

    //Moves the entity in one direction using transform.position
    public override void EnterState()
    {
        Debug.Log("Entered move in direction behaviour");
    }

    public override void RunBehaviour(float deltaTime)
    {
        _myTransform.position += _movementDirection * _movementSpeed * deltaTime;
    }

    public override void ExitState()
    {
        _myTransform.position = Vector3.zero;
        Debug.Log("Exited move in direction behaviour");
    }

    
}
