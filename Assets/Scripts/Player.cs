using UnityEngine;

public class Player : MonoBehaviour
{
    private InputSystem_Actions controller;
    private Vector2 moveInput;
    private Rigidbody rigidBody;

    private float moveSpeed;
    private int points = 0;

    void Awake()
    {
        controller = new InputSystem_Actions();
        rigidBody = GetComponent<Rigidbody>();
    }

    void OnEnable()
    {
        if (controller != null) {
            controller.Player.Enable();
        }
    }

    void OnDisable()
    {
        if (controller != null) {
            controller.Player.Disable();
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        moveSpeed = 15.0f;
    }


    // Update is called once per frame
    void Update()
    {
        moveInput = controller.Player.Move.ReadValue<Vector2>();
    }

    void FixedUpdate()
    {
        Vector3 movement = new Vector3(moveInput.x, 0f, moveInput.y) * moveSpeed;
        rigidBody.linearVelocity = new Vector3(movement.x, rigidBody.linearVelocity.y, movement.z);
    }

    public void AddPoint()
    {
        points++;
        Debug.Log($"Score: {points}");
    }

    public int GetPoints()
    {
        return points;
    }
}
