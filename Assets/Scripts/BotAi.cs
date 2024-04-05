using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class BotAI : MonoBehaviour
{
    [SerializeField] private Transform _player;
    [SerializeField] private float _speed;
    [SerializeField] private float _offsetDistance = 3f;

    private Rigidbody _rigidbody;
    private Vector3 _direction;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }


    void Update()
    {

        _direction = (_player.position - transform.position).normalized;


    }

    private void FixedUpdate()
    {
        if (Vector3.Distance(_player.position, transform.position) < _offsetDistance)
            return;

        _rigidbody.velocity = _direction * _speed;
    }
}
