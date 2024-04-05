using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private const string Horizontal = "Horizontal";
    private const string Vertical = "Vertical";
    [SerializeField] private float _speed = 1f;
    [SerializeField] private CharacterController _characterController;


    private void Update()
    {
        float inputX = Input.GetAxis(Horizontal);
        float inputY = Input.GetAxis(Vertical);

        Vector3 motion = new Vector3(inputX, 0, inputY) * _speed;
        //_characterController.Move(motion * Time.deltaTime);
        _characterController.SimpleMove(motion);
    }
}
