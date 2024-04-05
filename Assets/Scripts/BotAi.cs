using UnityEngine;


public class BotAI : MonoBehaviour
{
    [SerializeField] private Transform _target;

    [SerializeField] private float _offsetDistance = 3f;
    [SerializeField] private Mover _mover;

    private Vector3 _direction;

    void Update()
    {

        _direction = (_target.position - transform.position).normalized;


    }

    private void FixedUpdate()
    {
        if (Vector3.Distance(_target.position, transform.position) < _offsetDistance)
            return;

        _mover.Move(_direction);
    }
}
