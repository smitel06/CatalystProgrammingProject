using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public abstract class AICondition : ScriptableObject
{
    //Condition is called in AIState and returns a true or false to transition to another state
    //transition is used to dictate the next state in the cycle
    public abstract bool Condition();
    public AIStatemachine.AIState nextState;
}