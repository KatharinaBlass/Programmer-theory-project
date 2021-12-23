using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Dog : Animal
{
    // POLYMORPHISM
    public override void PresentSelf()
    {
        animator.SetBool("Sit_b", false);
        animator.SetBool("Bark_b", true);
    }
    // POLYMORPHISM
    public override void Relax()
    {
        animator.SetBool("Bark_b", false);
        animator.SetBool("Sit_b", true);
    }
    // POLYMORPHISM
    public override void Jump()
    {
        animator.SetBool("Bark_b", false);
        animator.SetBool("Sit_b", false);
        base.Jump();
    }

}
