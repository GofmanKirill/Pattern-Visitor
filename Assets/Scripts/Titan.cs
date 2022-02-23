using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Titan : Metal
{
    public override void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}
