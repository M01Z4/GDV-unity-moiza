using UnityEngine;

public class PhysicsController : MonoBehaviour
{
    private Rigidbody rb;
    public float springKracht = 500.0f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        if (rb == null)

        {
            Debug.Log("Geen Rigidbody gevonden! Voeg er een toe.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Spring!");
            rb.AddForce(Vector3.up * springKracht);
            rb.AddForce(Vector3.right * 10.0f);
        }
    }
}
