using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rooster : Animal
{
    public override void Start()
    {
        base.AnimalName = "Rooster Bob";
        base.Start();
    }

    public override void Relax()
    {
        animator.SetTrigger("Eat_b");
    }

    public override void Jump()
    {
        animator.SetBool("Eat_b", false);
        base.Jump();
    }
}
