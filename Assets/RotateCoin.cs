using JetBrains.Annotations;
using UnityEngine;

public class RotateCoin : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float speed = 20f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, speed * Time.deltaTime);
        // public Vector3 rotationspeed = new Vector3(0, 100, 0);

    }
    
}
