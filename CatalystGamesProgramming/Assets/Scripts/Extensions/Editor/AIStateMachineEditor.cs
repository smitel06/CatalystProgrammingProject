using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(AIStatemachine))]
public class AIStateMachineEditor : Editor
{
    //Controls the display of the AIStatemachine in the editor
    private AIStatemachine _statemachine;
    
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
    }
}
