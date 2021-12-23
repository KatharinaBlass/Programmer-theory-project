using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Rooster : Animal
{
    // POLYMORPHISM
    public override void Start()
    {
        base.AnimalName = "Rooster Bob";
        base.Start();
    }
    // POLYMORPHISM
    public override void Relax()
    {
        animator.SetTrigger("Eat_b");
    }
    // POLYMORPHISM
    public override void Jump()
    {
        animator.SetBool("Eat_b", false);
        base.Jump();
    }
}
