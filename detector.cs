using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detector : MonoBehaviour
{
    private Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        rend.material.color = Color.red;
    }
    private void OnCollisionStay(Collision other)
    {
        rend.material.color = Color.green;
    }
    private void OnCollisionExit(Collision other)
    {
        rend.material.color = Color.blue;
    }
}
