using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerMover : Mover
{
    private CharacterController _characterController;

    private void Awake()
    {
        _characterController = GetComponent<CharacterController>();
    }
    public override void Move(Vector3 direction)
    {
        _characterController.SimpleMove(direction * Speed);
    }
}
