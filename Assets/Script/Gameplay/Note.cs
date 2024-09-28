using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float speed;

    public bool canBePressed;

    private void Start()
    {
        speed = GameManager.instance.bpm / 35;
    }

    private void Update()
    {
        rb.velocity = new Vector2(0, -speed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Lose Trigger"))
        {
            GameManager.instance.ballSpeed += 0.5f;
            GameManager.instance.noteMiss++;
            GameManager.instance.score -= 4;
            Destroy(gameObject);
        }
    }
}
