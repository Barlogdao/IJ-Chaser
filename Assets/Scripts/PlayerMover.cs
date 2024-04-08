using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerMover : Mover
{
    [SerializeField] float _rotationSpeed;
    [SerializeField] PlayerInput _playerInput;

    private CharacterController _characterController;

    private void Awake()
    {
        _characterController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        Move(_playerInput.Direction);
        Rotate(_playerInput.Rotation);
    }

    private void Move(Vector3 directionInput)
    {
        Vector3 direction = transform.TransformDirection(directionInput);

        Vector3 motion = (direction * Speed + Physics.gravity) * Time.deltaTime;

        _characterController.Move(motion);
    }

    private void Rotate(Vector3 rotationInput)
    {
        Vector3 rotation = rotationInput * _rotationSpeed * Time.deltaTime;

        transform.Rotate(rotation);
    }
}