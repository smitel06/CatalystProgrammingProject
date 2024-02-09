using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class AIState : MonoBehaviour
{
    //This class will hold data to create bespoke states within the inspector
    //The state needs at least one condition and only one behaviour
    //A condition is the condition of leaving the state and the behaviour is the behaviour of the state
    //Will always check condition first then execute behaviour

    [SerializeField] public AIBehaviour _behaviour;
    [SerializeField] private List<AICondition> _conditions;
    [SerializeField] private AIStatemachine _stateMachine;

    public void OnTick(float deltaTime)
    {
        //Check all conditions first
        foreach (var condition in _conditions)
        {
            if(condition.Condition())
            {
                _stateMachine.SwitchState(condition._transition);
                return;
            }
        }

        //No conditions were true run behaviour

        _behaviour.RunBehaviour(deltaTime);
        
    }

}
