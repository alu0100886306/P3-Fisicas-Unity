using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iniMovement : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3[] direct;

    public float movement_force = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        direct = new Vector3[] { transform.forward, -transform.forward, transform.right, -transform.right };
    }
    
    // Update is called once per frame
    void FixedUpdate()
    {
        // Añade una fuerza al objeto en una dirección aleatoria
        rb.AddRelativeForce(direct[Random.Range(0, 3)] * movement_force);
    }
}
