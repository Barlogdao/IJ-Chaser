using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class BotMover : Mover
{
    [SerializeField] private Transform _target;
    [SerializeField] private float _offsetDistance = 3f;

    private Vector3 _direction;
    private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        _direction = (_target.position - transform.position).normalized;

        HandleRotation();
    }

    private void FixedUpdate()
    {
        HandleMovement();
    }

    private void HandleRotation()
    {
        Vector3 lookTarget = _target.position;
        lookTarget.y = transform.position.y;

        transform.LookAt(lookTarget);
    }

    private void HandleMovement()
    {
        if (Vector3.Distance(_target.position, transform.position) < _offsetDistance)
            return;

        Vector3 velocity = _direction * Speed;
        velocity.y = _rigidbody.velocity.y;

        _rigidbody.velocity = velocity;
    }
}