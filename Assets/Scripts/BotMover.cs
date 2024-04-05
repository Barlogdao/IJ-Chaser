using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class BotMover : Mover
{
    private Rigidbody _rigidbody;
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }
    public override void Move(Vector3 direction)
    {
        _rigidbody.velocity = direction * Speed;
    }
}
