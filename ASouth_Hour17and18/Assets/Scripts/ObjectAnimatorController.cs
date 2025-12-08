using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectAnimatorController : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("W pressed");
            animator.SetTrigger("ColorTrigger");
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("A pressed");
            animator.SetTrigger("ScaleTrigger");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("S pressed");
            animator.SetTrigger("SpinTrigger");
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("D Pressed");
            animator.SetTrigger("HoverTrigger");
        }
    }
}
