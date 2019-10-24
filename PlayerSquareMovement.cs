using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSquareMovement : MonoBehaviour
{
    public float speed;
    public float turn_speed;
    public int player_number;
    private int contador;
    private Renderer rend;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rend = GetComponent<Renderer>();
        speed = 10f;
        turn_speed = 80f;
        contador = 0;
        if (player_number % 2 == 0) {
            rend.material.color = new Color(255, 0, 0);
        }else {
            rend.material.color = new Color(0, 0, 255);
        }
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal" + player_number);
        float moveVertical = Input.GetAxis("Vertical" + player_number);
        float turnHorizontal = Input.GetAxis("Turn" + player_number);

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        Vector3 turnDirection = new Vector3(0, turnHorizontal, 0);

        rb.AddRelativeForce(movement * speed);
        //rb.MovePosition(movement * speed);
        Quaternion deltaRotation = Quaternion.Euler(turnDirection * turn_speed * Time.deltaTime);
        rb.MoveRotation(rb.rotation * deltaRotation);
    }



    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "BallObstacle") {
            contador++; 
            print("contador player" + player_number + ": " + contador);
        }
    }
}
