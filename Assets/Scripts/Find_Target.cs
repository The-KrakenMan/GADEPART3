using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Find_Target : StateMachineBehaviour
{
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.GetComponent<AI_Controller>().PlotACourse(GameObject.FindObjectOfType<WaypointMan>().GetWaypoint(animator.GetInteger("Target_Waypoint")+1, animator.GetBool("Cheating")));
    }
}
