using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;


[Serializable]
public class Clip{
    public string name;
    public AudioClip clip;
}

public class AudioManager : MonoBehaviour
{
    [SerializeField]private Clip[] clips;
    [SerializeField]private AudioSource audio;

    private void Start() {
       audio = GetComponent<AudioSource>();
       audio.clip = clips[1].clip;
       audio.Play();
    }


}
