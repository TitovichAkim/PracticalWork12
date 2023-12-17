using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAnimation : MonoBehaviour
{
    public Animator anim;

    private void Start ()
    {
        anim = GetComponent<Animator>();
    }

    public void Change ()
    {
        byte ran = (byte)Random.Range(0,3);
        switch(ran)
        {
            case 0:
                anim.SetInteger("Condition", 0);
                break;
            case 1:
                anim.SetInteger("Condition", 1);
                break;
            case 2:
                anim.SetInteger("Condition", 2);
                break;
        }
    }
}
