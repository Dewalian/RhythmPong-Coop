using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteSpawner : MonoBehaviour
{
    [SerializeField] private GameObject note;
    [SerializeField] private GameObject[] noteSpawner;

    [SerializeField] private bool onCD = false;
    [SerializeField] private float BPM;

    private void Start()
    {
        noteSpawner = GameObject.FindGameObjectsWithTag("Spawner");
        BPM = 60f / GameManager.instance.bpm;
    }

    private void Update()
    {
        if (GameManager.instance.isWin)
        {
            StopCoroutine(SpawnNoteDelay());
        }
        else if (!onCD)
        {
            StartCoroutine(SpawnNoteDelay());
        }
    }

    private void SpawnNotes()
    {
        int randomNumber = Random.Range(0, 4);
        Instantiate(note, noteSpawner[randomNumber].transform.position, Quaternion.identity);
    }

    private IEnumerator SpawnNoteDelay()
    {
        onCD = true;
        SpawnNotes();
        yield return new WaitForSeconds(BPM);
        onCD = false;
    }
}
