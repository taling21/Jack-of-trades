using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class WaypointPatrol : MonoBehaviour
{
    public NavMeshAgent navMeshAgent;
    public Transform[] waypoints;
    public Transform player;
    public Movement character;
    public int damage = 1;
    int m_CurrentWaypointIndex;
    /*
    void Start()
    {
        navMeshAgent.SetDestination(waypoints[1].position);
    }
    */
    void Awake()
    {
        player = GameObject.Find("character").transform;
    }
    void Update()
    {
        /*
        if(navMeshAgent.remainingDistance < navMeshAgent.stoppingDistance)
        {
            m_CurrentWaypointIndex = (m_CurrentWaypointIndex + 1) % waypoints.Length;
            //navMeshAgent.SetDestination (waypoints[m_CurrentWaypointIndex].position);
        }
        */
        navMeshAgent.SetDestination (player.position);
        if (navMeshAgent.remainingDistance<1.5f)
        character.TakeDamage(damage);

    }
    //navMeshAgent.SetDestination (waypoints[m_CurrentWaypointIndex].position);
    
}