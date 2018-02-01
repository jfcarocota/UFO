using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class AudioClips
{
    [SerializeField]
    List<AudioClip> clips;

    public AudioClip GetAudio(int index)
    {
        return clips[index];
    }
}
