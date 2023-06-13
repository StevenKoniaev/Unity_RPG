using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyNav : MonoBehaviour
{
    private NavMeshAgent navMeshAgent;
    [SerializeField] private Transform target;
   public void Awake(){
    navMeshAgent = GetComponent<NavMeshAgent>();
   }


   private void ChangeNav(Transform target){
        navMeshAgent.destination = target.position; 
   }
}
 