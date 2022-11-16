using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint_Lap : StateMachineBehaviour
{
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (animator.GetInteger("Target_Waypoint") == 9)
        {
            animator.SetInteger("Target_Waypoint", 0);
        }
    }
}
