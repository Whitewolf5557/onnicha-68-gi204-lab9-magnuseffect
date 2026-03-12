using UnityEngine;
using UnityEngine.InputSystem;

public class RotatewithTorque : MonoBehaviour
{
    public float torqueSpeed;

    Rigidbody rb;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Keyboard.current.dKey.isPressed)
        {
            rb.AddTorque(new Vector3(0, 0, torqueSpeed));
        }
    }
}
