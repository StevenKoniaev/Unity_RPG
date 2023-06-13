using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class AttackNode : Node
{
    private NavMeshAgent agent;
    private katana_man_AI ai;

    public AttackNode(katana_man_AI ai, NavMeshAgent agent){
        this.agent = agent;
        this.ai = ai;
    }

    public override NodeState Evaluate()
    {
        agent.isStopped = true;
        Debug.Log("ATTACKKK");
        return NodeState.RUNNING;
    }
}
