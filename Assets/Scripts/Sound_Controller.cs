using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound_Controller : MonoBehaviour
{

    public AudioClip[] clips;

    AudioSource sound;

    // Start is called before the first frame update
    void Awake()
    {
        sound = GetComponent<AudioSource>();
    }

    public void SoundPlay(int clip)
    {
        sound.clip = clips[clip];
        sound.Play(0);
    }

    

}
