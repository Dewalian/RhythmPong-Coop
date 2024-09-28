using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loader : MonoBehaviour
{
    [SerializeField] private GameObject gameManager;
    [SerializeField] private GameObject audioManager;

    private void Awake()
    {
        if(GameManager.instance == null)
        {
            Instantiate(gameManager);
        }

        if(AudioManager.instance == null)
        {
            Instantiate(audioManager);
        }
    }

    public void ChangeScenetoMainMenu()
    {
        SceneManager.LoadSceneAsync(0);
    }

    public void ChangeScenetoPlaylist()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void ChangeScenetoGameplay()
    {
        SceneManager.LoadSceneAsync(2);
    }

    public void PlaySFX(int index)
    {
        AudioManager.instance.PlaySFX(index);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
