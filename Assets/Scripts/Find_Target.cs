using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Find_Target : StateMachineBehaviour
{
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
      
        animator.GetComponent<AI_Controller>().Target =  GameObject.FindObjectOfType<WaypointMan>().GetWaypoint(animator.GetInteger("Target_Waypoint") + 1, animator.GetBool("Shortcut"));
    }
}
