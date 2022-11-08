using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointMan : MonoBehaviour
{

    public GameObject LoseScreen;
    public Rigidbody rb;
    private Vector3 DriverVelocity;
   
    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnTriggerEnter(Collider other)
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
        
    }
}
