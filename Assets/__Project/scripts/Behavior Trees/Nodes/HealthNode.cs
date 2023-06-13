using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthNode : Node
{
   private katana_man_AI ai;
   private float threshold;

   public HealthNode(katana_man_AI ai, float threshold){
    this.ai = ai;
    this.threshold = threshold;
   }

    public override NodeState Evaluate()
    {
        return ai.GetCurrentHealth() <= threshold ? NodeState.SUCCESS : NodeState.FAILURE;
    }
}
