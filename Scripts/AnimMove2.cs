using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class AnimMove2 : MonoBehaviour
{
    Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D))
        {
            anim.Play("Right");
        }
        else if (Input.GetKey(KeyCode.A))
        {
            anim.Play("Left");
        }
        else if (Input.GetKey(KeyCode.W))
        {
            anim.Play("Up");
        }
        else if (Input.GetKey(KeyCode.S))
        {
            anim.Play("Down");
        }
        else
            anim.Play("Idle");
    }
}
