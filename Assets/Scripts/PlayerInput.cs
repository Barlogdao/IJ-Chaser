using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private const string Horizontal = "Horizontal";
    private const string Vertical = "Vertical";

    public Vector3 Direction { get;private set; } 
    public Vector3 Rotation { get; private set; }

    private void Update()
    {
        Direction = new Vector3(0f, 0f, Input.GetAxis(Vertical));
        Rotation = new Vector3(0f, Input.GetAxis(Horizontal), 0f);
    }
}
