using UnityEngine;

public class RocketController : MonoBehaviour
{
    public float thrustForce = 10f; // How powerful the rocket boost is
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>(); // Grab that Rigidbody component
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            LaunchRocket();
        }
    }

    void LaunchRocket()
    {
        rb.AddForce(Vector3.up * thrustForce); // Apply upward force
    }
}
