using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Free_Will : StateMachineBehaviour
{
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (Random.Range(0,2) == 0)
        {
            animator.SetBool("Shortcut", true);
        }
        else
        {
            animator.SetBool("Shortcut", false);
        }
    }

    
}
