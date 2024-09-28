using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PongBoard : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float speed = 10f;

    [SerializeField] private KeyCode moveUp = KeyCode.W;
    [SerializeField] private KeyCode moveDown = KeyCode.S;

    private void Update()
    {
        if (Input.GetKey(moveUp))
        {
            rb.velocity = new Vector2(0, speed);
        }
        else if (Input.GetKey(moveDown))
        {
            rb.velocity = new Vector2(0, -speed);
        }
        else
        {
            rb.velocity = Vector2.zero;
        }

        
    }
}
