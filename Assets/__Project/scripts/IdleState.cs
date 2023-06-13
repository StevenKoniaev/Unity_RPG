using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : state
{
    public ChaseState chaseState;
    public bool canSeeTarget;
    public override state RunCurrentState()
    {
        if (canSeeTarget){
            return chaseState;
        }
        else {
            return this;
        }
    }
}
