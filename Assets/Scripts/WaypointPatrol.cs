using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class WaypointPatrol : MonoBehaviour
{
    public NavMeshAgent navMeshAgent;
    //public Transform[] waypoints;
    public Transform player;
    public Movement character;
    public int damage = 1;
    //public Animator anim ;
    public bool isattacking;
    //int m_CurrentWaypointIndex;
    /*
    void Start()  
    {
        navMeshAgent.SetDestination(waypoints[1].position);
    }
    */
    void Awake()
    {
        player = GameObject.Find("character").transform;
        isattacking = false; 

    }
    void Update()
    {
        
        isattacking = false;
        navMeshAgent.SetDestination (player.position);
        if (navMeshAgent.remainingDistance<3.0f){

        
        character.TakeDamage(damage);
       // isattacking =true;

        }
        //anim.SetBool("IsAttacking",isattacking);

    }
    //navMeshAgent.SetDestination (waypoints[m_CurrentWaypointIndex].position);
    
}