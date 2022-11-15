using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour
{
    public static SFXManager instance;

    public Hashtable hasht1;
    public Hashtable hasht2;
    public AudioSource pCrash;
    public AudioSource pWin;
    public AudioSource pGameover;

    // Start is called before the first frame update
    void Start()
    {
        hasht1 = new Hashtable();
        hasht1.Add(1, "crash");
        hasht1.Add(2, "Win");
        hasht1.Add(3, "gameOver");

        Dictionary<int, AudioSource> audioSource = new Dictionary<int, AudioSource>();
        audioSource.Add(1, pCrash);
        audioSource.Add(2, pWin);
        audioSource.Add(3, pGameover);

        hasht2 = new Hashtable(audioSource);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
