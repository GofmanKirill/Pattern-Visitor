using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckMetal : MonoBehaviour, IVisitor
{
    public void Visit(Silver silver)
    {
        Print(silver.GetType().ToString(), silver.Mass);
    }

    public void Visit(Titan titan)
    {
        Print(titan.GetType().ToString(), titan.Mass);
    }

    public void Visit(Gold gold)
    {
        Print(gold.GetType().ToString(), gold.Mass);
    }




    private void Print(string nameMetal, float massMetal)
    {
        Debug.Log($"This is {nameMetal}");
        Debug.Log($"Mass: {massMetal}t");
    }




    private void OnTriggerEnter(Collider collider)
    {
        if (collider.TryGetComponent(out Metal metal))
        {
            metal.Accept(this);
        }
    }
}
