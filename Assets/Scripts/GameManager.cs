using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField]
    Score score;
    [SerializeField]
    AudioClips audioClips;
    AudioSource aud;

    public Score Score
    {
        get
        {
            return score;
        }
    }

    void Awake()
    {
        instance = this;
        aud = GetComponent<AudioSource>();
    }

    public void PlayAudioClip(int index)
    {
        aud.PlayOneShot(audioClips.GetAudio(index));
    }
}
