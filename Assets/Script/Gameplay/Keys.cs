using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Keys : MonoBehaviour
{
    [SerializeField] private KeyCode key;
    [SerializeField] private LayerMask NoteLayer;
    [SerializeField] private float RangeCheck;
    [SerializeField] private TMP_Text textKeyScore;
    [SerializeField] private GameObject canvasScore;

    [SerializeField] private Sprite buttonUp;
    [SerializeField] private Sprite buttonDown;

    private SpriteRenderer render;
    private bool hitNow;
    private Transform note;

    private void Start()
    {
        render = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if(Input.GetKeyDown(key) && hitNow)
        {
            Debug.Log("masuk");
            Collider2D[] CheckScore = Physics2D.OverlapCircleAll(transform.position, RangeCheck, NoteLayer);
            if(CheckScore.Length == 1)
            {
                SpawnTextKeyScore("Mid", Color.blue);
                GameManager.instance.score += 5;
                if(GameManager.instance.ballSpeed > GameManager.instance.minBallSpeed) GameManager.instance.ballSpeed -= 0.2f;
            }
            else if(CheckScore.Length == 2)
            {
                SpawnTextKeyScore("Good", Color.yellow);
                GameManager.instance.score += 8;
                if (GameManager.instance.ballSpeed > GameManager.instance.minBallSpeed) GameManager.instance.ballSpeed -= 0.4f;
            }
            else if(CheckScore.Length == 3)
            {
                SpawnTextKeyScore("Perfect!", Color.green);
                GameManager.instance.score += 12;
                if (GameManager.instance.ballSpeed > GameManager.instance.minBallSpeed) GameManager.instance.ballSpeed -= 0.6f;
            }
            else
            {
                SpawnTextKeyScore("Bad", Color.red);
            }
            GameManager.instance.noteHit++;
            Destroy(note.gameObject);
        }

        if (Input.GetKeyDown(key))
        {
            render.sprite = buttonDown;
            AudioManager.instance.PlaySFX(0);
        }
        else if (Input.GetKeyUp(key))
        {
            render.sprite = buttonUp;
        }
    }

    private void SpawnTextKeyScore(string score, Color color)
    {
        textKeyScore.SetText(score);
        textKeyScore.color = color;
        TMP_Text tempText = Instantiate(textKeyScore, transform.position, Quaternion.identity);
        
        tempText.transform.SetParent(canvasScore.transform, false);
        tempText.transform.position = new Vector2(transform.position.x, transform.position.y + 1f);
        Destroy(tempText, 0.5f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Note"))
        {
            hitNow = true;
            note = collision.transform;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Note"))
        {
            hitNow = false;
        }
    }
}
