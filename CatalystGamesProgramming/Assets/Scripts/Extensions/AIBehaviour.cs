using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class AIBehaviour : MonoBehaviour
{
    //Controls the behaviour and transitions foreach dynamically created state
    //Enter is called on the start of the state
    //Exit is called on the end of the state
    //Run behaviour executres until an AICondition.Condition returns true
    //Each state can handle its own components 


    public virtual void EnterState() { }
    public virtual void RunBehaviour(float deltaTime) { }
    public virtual void ExitState() { }
}
