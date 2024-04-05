using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class Mover : MonoBehaviour
{
    [field: SerializeField] protected float Speed;
    public abstract void Move(Vector3 direction);
}
