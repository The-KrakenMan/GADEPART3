using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointMan : MonoBehaviour
{

    public GameObject LoseScreen;
    public Rigidbody rb;
    private Vector3 DriverVelocity;
 
    public GameObject[] Waypoints;
   
    // Update is called once per frame
    void Update()
    {
       
    }

    void Start()
    {
        
    }

    /* private void OnTriggerEnter(Collider other)
     {
         if (other.gameObject.tag == "Enemy")
         {
             if (other.GetComponent<AI_Controller>().LapCounter < 18)
             {
                 // other.GetComponent<AI_Controller>().WaypointList.RemoveFirst();
                 rb = other.GetComponent<Rigidbody>();
                 DriverVelocity = rb.velocity;
                 other.GetComponent<AI_Controller>().PlotACourse();
                 other.GetComponent<Rigidbody>().velocity = DriverVelocity;
             }
             else
             {
                 LoseScreen.SetActive(true);
             }


         }

         if (other.gameObject.tag == "Player")
         {
             if (other.GetComponent<Player>().WaypointCount == 5)
             {
                 other.GetComponent<Player>().Lap();
                 other.GetComponent<Player>().WaypointCount = 0;

             }
             else
             {
                 other.GetComponent<Player>().WaypointCount++;
             }

         }

     }*/



    public Vector3 GetWaypoint(int Waypoint, bool cheating = false)
    {
        foreach (GameObject W in Waypoints)
        {
            if (W.GetComponent<Waypoint_Trigger>().Target_Waypoint == Waypoint && W.GetComponent<Waypoint_Trigger>().shortcut == false)
            {
                return W.transform.position;
            }
        }
        return new Vector3();
    }

    public void Reset()
    {
        GameObject Target;
        for (int i = 0; i < 9; i++)
        {
            Target = Waypoints[i];
            Target.GetComponent<Waypoint_Trigger>().Passed = false;
        }
    }
}
