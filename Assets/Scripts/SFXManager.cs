using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour
{
    public static SFXManager instance;

    public Hashtable hasht2;
    public AudioSource pCrash;
    public AudioSource pWin;
    public AudioSource pGameover;
    public AudioSource pAcceleration;
    public AudioSource pBrake;
    Dictionary<string, AudioSource> audioSource;

    // Start is called before the first frame update
    void Start()
    {
   
        audioSource = new Dictionary<string, AudioSource>();
        audioSource.Add("Crash", pCrash);
        audioSource.Add("Win", pWin);
        audioSource.Add("GameOver", pGameover);
        audioSource.Add("Acceleration", pAcceleration);
        audioSource.Add("Brake", pBrake);

        hasht2 = new Hashtable(audioSource);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlaySound(string soundName)
    {
        AudioSource PLAYING;
        PLAYING = (AudioSource)hasht2[soundName];
        PLAYING.Play(); 
    }

    public void StopSound(string soundName)
    {
        AudioSource PLAYING;
        PLAYING = (AudioSource)hasht2[soundName];
        PLAYING.Stop();


    }


}
