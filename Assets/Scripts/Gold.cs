using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gold : Metal
{
    public override void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}
