using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slide : MonoBehaviour
{
    Animator anim;
    public Collider norm;
    public Collider slide;
    public Collider jump;
    public float time = 1f;

    void Update()
    {
        anim = gameObject.GetComponent<Animator>();
        if (Input.GetKeyDown(KeyCode.S))
        {
            anim.SetTrigger("Slide");
            norm.enabled = false;
            slide.enabled = true;
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            anim.SetTrigger("Up");
            norm.enabled = true;
            slide.enabled = false;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            anim.SetTrigger("Jump");
            norm.enabled = false;
            jump.enabled = true;
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            anim.SetTrigger("Up");
            norm.enabled = true;
            jump.enabled = false;
            time = .67f;
        }
        if (Input.GetKey("w"))
        {
            time -= Time.deltaTime;
        }
        if (time < 0)
        {
            norm.enabled = true;
            jump.enabled = false;
        }
    }
}
