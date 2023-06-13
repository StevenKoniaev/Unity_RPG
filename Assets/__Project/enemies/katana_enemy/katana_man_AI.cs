using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class katana_man_AI : MonoBehaviour
{
    [SerializeField] private float startingHealth;
    [SerializeField] private float chaseRange;
    [SerializeField] private float attackRange;
    [SerializeField] private Transform playerPosition;
    private Animator _animator;
    private float currentHealth;
    private NavMeshAgent agent;
    //The first node in the behavior tree
    private Node topNode;

    private void Start(){
        currentHealth = startingHealth;
        _animator = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
        ConstructBehaviorTree();
    }

    public float GetCurrentHealth(){
        return currentHealth;
    }

    private void ConstructBehaviorTree(){
        HealthNode healthNode = new HealthNode(this, 5);
        ChaseNode chaseNode = new ChaseNode(playerPosition, agent);
        RangeNode rangeNode = new RangeNode(chaseRange, playerPosition, transform);
        AttackNode attackNode = new AttackNode(this, agent);
        AttackRangeNode attackRangeNode = new AttackRangeNode(attackRange, playerPosition, transform);
        Sequence chaseSequence = new Sequence(new List<Node> {rangeNode, chaseNode});
        Sequence attackSequence = new Sequence(new List<Node> {attackRangeNode, attackNode});

        //TOP
        topNode = new Selector(new List<Node> {attackSequence, chaseSequence});
    }

    private void Update() {
        topNode.Evaluate();
    }
}
