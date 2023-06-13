using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseState : state
{
    public AttackState attackState;
    public bool inAttackRange;
    public override state RunCurrentState() 
    {
       
        return this;
    }
}
