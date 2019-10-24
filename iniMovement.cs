using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iniMovement : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3[] direc= {transform.forward,-transform.forward,transform.right,-transform.right};

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();        
    }

    // Update is called once per frame
    void Update()
    {	
	int index = Random.Range(0, 3);
        rb.AddRelativeForce( direc[index] * 150);
    }
}
