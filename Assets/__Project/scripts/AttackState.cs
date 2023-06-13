using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackState : state
{
    public override state RunCurrentState()
    {
         Debug.Log("IHAVE ATTACKED");
        return this;
    }
}
