using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Silver : Metal
{
    public override void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}
