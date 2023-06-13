using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sequence : Node
{
    protected List<Node> nodes = new List<Node>();
    public Sequence(List<Node> nodes){
        this.nodes = nodes;
    }
    public override NodeState Evaluate()
    {
        bool isAnyChildRunning = false;
        foreach (var node in nodes){
            switch (node.Evaluate()){
                case NodeState.RUNNING:
                    isAnyChildRunning = true;
                    break;
                case NodeState.SUCCESS:
                    break;
                case NodeState.FAILURE:
                _nodeState = NodeState.FAILURE;
                return _nodeState;
                default:
                    break;
            }
        }
        _nodeState = isAnyChildRunning ? NodeState.RUNNING : NodeState.SUCCESS;
        return _nodeState;
    }
}
