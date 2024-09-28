using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicSelect : MonoBehaviour
{
    [SerializeField] private ScriptableSong music;

    public void musicSelect()
    {
        GameManager.instance.music = music;
    }
}
