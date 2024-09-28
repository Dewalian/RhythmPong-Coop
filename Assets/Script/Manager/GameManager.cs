using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;

    public ScriptableSong music;

    public int point = 3;
    public float bpm = 120f;
    public float ballSpeed = 4f;
    public bool isWin = false;
    public bool isLose = false;
    public float maxBallSpeed = 30f;
    public float minBallSpeed = 4f;

    public float remainingTime;
    public int noteHit;
    public int noteMiss;
    public int score;

    [SerializeField] private Ball ball;

    public Vector2 center;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else if(instance != this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }
    
    private void Start()
    {   
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == "Gameplay")
        {
            ball = FindObjectOfType<Ball>();
            center = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width / 2, Screen.height / 2));
            AudioManager.instance.musicSource.Stop();
            AudioManager.instance.PlayMusic(music.song);
            ballSpeed = minBallSpeed;
            bpm = music.bpm;
            remainingTime = music.duration;
            isWin = false;
            isLose = false;
            point = 3;

            noteHit = 0;
            noteMiss = 0;
            score = 0;

            Time.timeScale = 1;
        }

    }

    private void Update()
    {
        if(remainingTime <= 0)
        {
            isWin = Win();
        }
        else
        {
            remainingTime -= Time.deltaTime;
        }
    }

    public void LosePoint()
    {
        point--;
        if (point > 0)
        {
            ball = FindObjectOfType<Ball>();
            Instantiate(ball, center, Quaternion.identity);
            ballSpeed = minBallSpeed;
        }
        else
        {
            AudioManager.instance.StopMusic();
            Time.timeScale = 0;
            isLose = Lose();
        }
    }

    public bool Win()
    {
        score += (point + 1) * 10;
        score += 100;
        return true;
    }

    public bool Lose()
    {
        score += (point + 1) * 10;
        return true;
    }
}
