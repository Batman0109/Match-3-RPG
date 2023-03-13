using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Horus : MonoBehaviour
{
    public Animator animator;

    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    public void Attack()
    {
        animator.SetTrigger("Horus Attack");
    }

}