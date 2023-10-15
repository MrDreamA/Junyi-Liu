using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioToggle : MonoBehaviour
{
    public AudioSource AudioSource;

   public void Start()
    {
        AudioSource = GetComponent<AudioSource>();
    }

    public void ToggleSound()
    {
        if(AudioSource.isPlaying)
        {
            AudioSource.Pause();
        }
        else
        {
            AudioSource.Play();
        }
    }
}
