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

    // audio testing. erase this later
    void OnGUI()
    {
        if (GUI.Button(new Rect(10, 70, 150, 30), "Pause"))
        {
            audio.Pause();
            Debug.Log("Pause: " + audio.time);
        }

        if (GUI.Button(new Rect(10, 120, 150, 30), "Play death"))
        {
            Debug.Log("clip name = "+ audio.clip);
            audio.clip = dying;
            audio.Play();
        }

        if (GUI.Button(new Rect(10, 170, 150, 30), "Play main tune"))
        {
            Debug.Log("clip name = " + audio.clip);
            audio.clip = mainTune;
            audio.Play();
        }
 
        if (GUI.Button(new Rect(10, 230, 150, 30), "Continue"))
        {
            audio.UnPause();
        }
    }
}
