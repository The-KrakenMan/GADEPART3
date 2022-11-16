using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint_Trigger : MonoBehaviour
{
    public int Target_Waypoint;
    public bool shortcut = false;
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
        if (other.tag != "Player")
        {
            other.gameObject.GetComponent<Animator>().SetInteger("Target_Waypoint", Target_Waypoint);
        }
        else
        {

        }
    }
}
