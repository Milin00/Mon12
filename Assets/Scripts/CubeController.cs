using UnityEngine;

using UnityEngine.InputSystem;

public class CubeController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5.0f;
    [SerializeField] private float jumpForce = 8.0f;
    private Vector3 move;
    private Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Vector3 moveDirection = new Vector3(move.x, 0, move.z);
        transform.Translate(moveDirection, Space.World);
    }

    private void OnMove(InputValue val)
    {
        Vector2 input = val.Get <Vector2 >();
        move = new Vector3(input.x,0,input.y)* moveSpeed * Time.deltaTime;  
    }

   
}
