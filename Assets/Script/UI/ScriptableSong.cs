using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Song", menuName = "Scriptable Object/Song")]
public class ScriptableSong : ScriptableObject
{
    public string songName;
    public AudioClip song;
    public float bpm;
    public float duration;
}
