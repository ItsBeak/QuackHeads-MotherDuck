using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QH_FeetSpinner : MonoBehaviour
{

    Rigidbody RB;

    //[SerializeField] bool moveFeet;

    public Animator anim;

    void Start()
    {
        RB = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (RB.velocity.x > 0 || RB.velocity.y > 0 || RB.velocity.z > 0)
        {
            //moveFeet = true;
            anim.SetBool("isMoving", true);
        }
        else
        {
            //moveFeet = false;
            anim.SetBool("isMoving", false);
        }
    }
}
