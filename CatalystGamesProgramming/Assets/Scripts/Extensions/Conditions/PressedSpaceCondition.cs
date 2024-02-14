using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "AICondition/PressedSpaceCondition")]
public class PressedSpaceCondition : AICondition
{
    public override bool Condition()
    {
        return Input.GetKeyDown(KeyCode.Space);
    }
}
