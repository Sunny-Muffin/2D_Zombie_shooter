using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public Audio[] audios;

    private void Awake()
    {
        foreach (var audio in audios)
        {
            audio.audioSource = gameObject.AddComponent<AudioSource>();
            audio.audioSource.clip = audio.audioClip;
            audio.audioSource.volume = audio.volume;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play(string name)
    {
        foreach (var audio in audios)
        {
            if (audio.name == name)
            {
                audio.audioSource.Play();
            }
        }
    }
}

[System.Serializable]
public class Audio
{
    public string name;

    [Range(0, 1)]
    public float volume;

    public AudioClip audioClip;
    public AudioSource audioSource;
}