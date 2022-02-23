using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IVisitor
{
    public void Visit(Silver silver);
    public void Visit(Titan titan);
    public void Visit(Gold gold);
}
