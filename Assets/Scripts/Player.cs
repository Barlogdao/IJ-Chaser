using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private const string Horizontal = "Horizontal";
    private const string Vertical = "Vertical";

    [SerializeField] private Mover _mover;


    private void Update()
    {
        float inputX = Input.GetAxis(Horizontal);
        float inputY = Input.GetAxis(Vertical);

        Vector3 direction = new Vector3(inputX, 0, inputY);

        _mover.Move(direction);
    }
}
