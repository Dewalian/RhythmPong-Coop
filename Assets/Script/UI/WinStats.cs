using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WinStats : MonoBehaviour
{
    [SerializeField] private TMP_Text lives, noteHit, noteMiss, Score;

    private void Start()
    {
        lives.text = string.Format("Lives             :   {0}", GameManager.instance.point);
        noteHit.text = string.Format("Note hit         :   {0}", GameManager.instance.noteHit);
        noteMiss.text = string.Format("Note missed :   {0}", GameManager.instance.noteMiss);
        Score.text = string.Format("Total score    :   {0}", GameManager.instance.score);
    }
}
