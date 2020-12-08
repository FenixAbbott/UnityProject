using UnityEngine;
public class VehicleMove : MonoBehaviour
{
    public float force = 1.0f;
    public Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        rb.AddForce(transform.right * force);
    }
}