using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIStatemachine : MonoBehaviour
{
    //Controls the transition of AIStates and dynamically creates them using a creation method
    //Use the inspector to drag reasons and conditions together to create states
    //On awake it will enter the fist state in the list of states
    //After that order of states does not matter

    [SerializeField] private List<AIState> _states;
    private AIState _currentState;

    [Tooltip("Create states by dragging in required components")]


    private void Awake()
    {

        _currentState._behaviour.EnterState();
    }

    // Update is called once per frame0
    void Update()
    {
        _currentState.OnTick(Time.deltaTime);
    }

    public void SwitchState(AIState newState)
    {
        _currentState._behaviour.ExitState();

        _currentState = newState;

        _currentState._behaviour.EnterState();

        _currentState._behaviour._stateMachine = this;
    }

    [System.Serializable]
    public class AIState
    {
        //This class will hold data to create bespoke states within the inspector
        //The state needs at least one condition and only one behaviour
        //A condition is the condition of leaving the state and the behaviour is the behaviour of the state
        //Will always check condition first then execute behaviour

        [SerializeField] public AIBehaviour _behaviour;
        [SerializeField] private List<ChangeTrigger> _conditions;
        [SerializeField] private AIStatemachine _stateMachine;
        

        public void OnTick(float deltaTime)
        {
            //Check all conditions first
            foreach (var changeTrigger in _conditions)
            {
                if (changeTrigger.condition.Condition())
                {
                    _stateMachine.SwitchState(changeTrigger.nextState);
                    return;
                }
            }

            //No conditions were true run behaviour

            _behaviour.RunBehaviour(deltaTime);

        }

    }

    [System.Serializable]
    public class ChangeTrigger
    {
        [SerializeField] public AICondition condition;
        [SerializeField] public AIState nextState;
    }
}
