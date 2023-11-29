using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioSource audioSourceMusicaDeFundo;
public AudioClip[] musicaDeFundo;

    // Start is called before the first frame update
    void Start()
    {
      AudioClip musicaDeFundoFase =  musicaDeFundo[0];
      audioSourceMusicaDeFundo.clip = musicaDeFundoFase;
      audioSourceMusicaDeFundo.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
