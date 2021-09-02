using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSound : MonoBehaviour
{

    AudioSource source;

    public AudioClip[] sounds;




    void Start()
    {
        source = GetComponent<AudioSource>();
        int randomSounds = Random.Range(0, sounds.Length);
        source.clip = sounds[randomSounds];
        source.Play();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
