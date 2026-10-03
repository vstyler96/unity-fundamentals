using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody rigidBody;

    void Awake()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    public void ResetPhysics()
    {
        rigidBody.angularVelocity = Vector3.zero;
        rigidBody.linearVelocity = Vector3.zero;
        transform.position = new Vector3(0, 0.5f, 0);
    }
}
