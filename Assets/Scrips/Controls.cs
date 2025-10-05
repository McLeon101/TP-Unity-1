using UnityEngine;
using UnityEngine.InputSystem;

public class Controls : MonoBehaviour
{
    private Rigidbody rb;

    public float velocidad = 5f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private Vector2 moveInput;

    public void OnMove(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
    }

    void Update()
    {
        Vector3 movement = new Vector3(moveInput.x, 0, moveInput.y);
        transform.Translate(movement * 5f * Time.deltaTime, Space.World);
    }
}
