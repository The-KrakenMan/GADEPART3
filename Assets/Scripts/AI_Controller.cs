using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AI_Controller : MonoBehaviour
{
    public NavMeshAgent Racer;
    public GameObject Waypoint1;
    public GameObject Waypoint2;
    public GameObject Waypoint3;
    public GameObject Waypoint4;
    public GameObject Waypoint5;
    public GameObject Waypoint6;
    public GameObject Target;
    public LinkedList<GameObject> WaypointList;
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
        PlotACourse();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlotACourse()
    {

        /*Vector3 LocalPos;
        Vector3 WorldPos;

        LocalPos = WaypointList.First.Value.transform.position;
        WorldPos = transform.TransformVector(LocalPos);

        Racer.SetDestination(WorldPos);*/

        currentWaypoint++;

        switch (currentWaypoint)
        {
            case 1:
                Racer.SetDestination(Waypoint1.transform.position);
                break;
            case 2:
                Racer.SetDestination(Waypoint2.transform.position);
                break;
            case 3:
                Racer.SetDestination(Waypoint3.transform.position);
                break;
            case 4:
                Racer.SetDestination(Waypoint4.transform.position);
                break;
            case 5:
                Racer.SetDestination(Waypoint5.transform.position);
                break;
            case 6:
                Racer.SetDestination(Waypoint6.transform.position);
                currentWaypoint = 0;
                break;
        }

    }
}
