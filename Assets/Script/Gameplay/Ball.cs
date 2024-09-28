using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float speed;

    private void Start()
    {
        Invoke(nameof(RandomStart), 2f);
    }

    private void Update()
    {
        speed = GameManager.instance.ballSpeed;
        GameManager.instance.ballSpeed += Time.deltaTime;
    }

    private void RandomStart()
    {
        int randomNumber = Random.Range(0, 2);
        if (randomNumber == 0)
        {
            rb.velocity = new Vector2(-1 * speed, 1 * speed);
        }
        else
        {
            rb.velocity = new Vector2(1 * speed, -1 * speed);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.CompareTag("Board") && GameManager.instance.ballSpeed < GameManager.instance.maxBallSpeed)
        {
            GameManager.instance.ballSpeed += 1f;
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y).normalized * speed;
        }
        AudioManager.instance.PlaySFX(1);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Lose Trigger"))
        {
            GameManager.instance.LosePoint();
            Destroy(gameObject);
        }
    }
}
