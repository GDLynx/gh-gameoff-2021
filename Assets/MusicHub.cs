using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicHub : MonoBehaviour
{
    public new AudioSource audio;
    public AudioClip dying;
    public AudioClip mainTune;
    public Global global;


    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
        audio.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (global.bloodPressure >= 0.7f && audio.clip != dying)
        {
            PlayDying(); 
        } else if (global.bloodPressure < 0.7f && audio.clip != mainTune)
        {
            PlayMainTune();
        }
    }

    void PlayDying()
    {
        audio.clip = dying;
        audio.Play();
    }

    void PlayMainTune()
    {
        audio.clip = mainTune;
        audio.Play();
    }

}
