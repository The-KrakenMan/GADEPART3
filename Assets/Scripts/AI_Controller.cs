using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AI_Controller : MonoBehaviour
{
    public NavMeshAgent Racer;
    public int LapCounter = 0;
    public int currentWaypoint = 0;
    
   
    // Start is called before the first frame update
    void Start()
    {
        /*WaypointList = new LinkedList<GameObject>(); 
        WaypointList.AddLast(Waypoint2);
        WaypointList.AddLast(Waypoint3);
        WaypointList.AddLast(Waypoint4);
        WaypointList.AddLast(Waypoint5);
        WaypointList.AddLast(Waypoint6);
        WaypointList.AddLast(Waypoint1);*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlotACourse(Vector3 Target)
    {
        Racer.SetDestination(Target);
    }
}
