using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public abstract class AIBehaviour : ScriptableObject
{
    //Controls the behaviour and transitions foreach dynamically created state
    //Enter is called on the start of the state
    //Exit is called on the end of the state
    //Run behaviour executres until an AICondition.Condition returns true
    //Each state can handle its own components 
    public AIStatemachine _stateMachine;

    public abstract void EnterState();
    public abstract void RunBehaviour(float deltaTime);
    public abstract void ExitState();
}
