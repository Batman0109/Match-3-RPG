using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anubis : MonoBehaviour
{
    public Animator animator;

    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    public void Attack()
    {
        animator.SetTrigger("Attack");
    }

}

