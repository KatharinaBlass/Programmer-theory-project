using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Chicken : Animal
{
    // POLYMORPHISM
    public override void Start()
    {
        base.AnimalName = "Chick Sarah";
        base.Start();
    }
}
