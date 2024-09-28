using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Panels : MonoBehaviour
{
    [SerializeField] private GameObject pause;
    [SerializeField] private GameObject win;
    [SerializeField] private GameObject lose;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0;
            pause.SetActive(true);
            AudioManager.instance.musicSource.Pause();
        }

        if (GameManager.instance.isWin)
        {
            WinPanel();
        }else if (GameManager.instance.isLose)
        {
            LosePanel();
        }
    }

    public void Unpause()
    {
        pause.SetActive(false);
        Time.timeScale = 1;
        AudioManager.instance.musicSource.UnPause();
    }

    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().name);
    }

    public void ExittoMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadSceneAsync("Main menu");
        AudioManager.instance.musicSource.clip = AudioManager.instance.themeSong.song;
        AudioManager.instance.musicSource.Play();
    }

    public void WinPanel()
    {
        Time.timeScale = 0;
        win.SetActive(true);
    }

    public void LosePanel()
    {
        Time.timeScale = 0;
        lose.SetActive(true);
    }
}
