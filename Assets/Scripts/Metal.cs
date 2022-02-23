using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Metal : MonoBehaviour
{
    [SerializeField]private float _mass;
    public float Mass { get => _mass; }
    public abstract void Accept(IVisitor visitor);
}
