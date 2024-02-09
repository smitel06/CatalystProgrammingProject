using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIStatemachine : MonoBehaviour
{
    //Controls the transition of AIStates and dynamically creates them using a creation method
    //Use the inspector to drag reasons and conditions together to create states
    //On awake it will enter the fist state in the list of states
    //After that order of states does not matter

    [SerializeField] private AIState _currentState;

    [Tooltip("Create states by dragging in required components")]
    

    private void Awake()
    {
        _currentState._behaviour.EnterState();
    }

    // Update is called once per frame
    void Update()
    {
        _currentState.OnTick(Time.deltaTime);
    }

    public void SwitchState(AIState newState)
    {
        _currentState._behaviour.ExitState();

        _currentState = newState;

        _currentState._behaviour.EnterState();
    }
}
