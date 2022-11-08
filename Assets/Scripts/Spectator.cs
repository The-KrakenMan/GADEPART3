using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spectator : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator anim;
    int RandomInt;
    bool Idling = true;
    void Start()
    {
        StartCoroutine(STARTANIM());

    }

  IEnumerator IDLE()
    {
        int RandomInt = Random.Range(0, 8);
        yield return new WaitForSeconds(RandomInt);
        anim.SetBool("Random1", false);
        anim.SetBool("Random2", false);
        anim.SetBool("Random3", false);
        anim.SetBool("Random4", false);
        Idling = true;
    }

    IEnumerator STARTANIM()
    {
        int RandomInt = Random.Range(0,10);
        yield return new WaitForSeconds(RandomInt);
        RandomInt = Random.Range(0, 4);
        switch (RandomInt)
        {
            case 0:
                anim.SetBool("Random1", true);
                Idling = false;
                break;
            case 1:
                anim.SetBool("Random2", true);
                Idling = false;
                break;
            case 2:
                anim.SetBool("Random3", true);
                Idling = false;
                break;
            case 3:
                anim.SetBool("Random4", true);
                Idling = false;
                break;

        }
        StartCoroutine(IDLE());

    }

    // Update is called once per frame
    void Update()
    {
        if (Idling == true)
        {
            int RandomInt = Random.Range(0, 4);
            switch (RandomInt)
            {
                case 0:
                    anim.SetBool("Random1", true);
                    Idling = false;
                    break;
                case 1:
                    anim.SetBool("Random2", true);
                    Idling = false;
                    break;
                case 2:
                    anim.SetBool("Random3", true);
                    Idling = false;
                    break;
                case 3:
                    anim.SetBool("Random4", true);
                    Idling = false;
                    break;

            }
            StartCoroutine(IDLE());
        }   
    }
}
