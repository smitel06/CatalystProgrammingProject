using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "AIBehaviour/RotateInDirection")]
public class RotateInDirection : AIBehaviour
{
    [SerializeField] private Vector3 _rotationDirection;
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private Transform _myTransform;

    public override void EnterState()
    {
        
    }

    public override void RunBehaviour(float deltaTime)
    {
        _myTransform.Rotate(_rotationDirection * _rotationSpeed * deltaTime);
    }

    public override void ExitState()
    {
        
    }

    

    
}
