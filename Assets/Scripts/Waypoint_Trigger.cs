using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint_Trigger : MonoBehaviour
{
    public int Target_Waypoint;
    public bool shortcut = false;
    public bool Passed = false;
    public int WaypointCounter = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            other.gameObject.GetComponent<Animator>().SetInteger("Target_Waypoint", Target_Waypoint);
            WaypointCounter++;
            if (WaypointCounter == 21)
            {
                GameObject Player = GameObject.FindWithTag("Player");
                Player.GetComponent<Player>().Lose();
            }
        }
        else
        {
            if (other.tag == "Player")
            {
                if (Passed == false)
                {
                    other.GetComponent<Player>().WaypointCount++;
                    other.GetComponent<Player>().Lap();
                    Passed = true;
                }
               
            }
        }
        
    }
}
