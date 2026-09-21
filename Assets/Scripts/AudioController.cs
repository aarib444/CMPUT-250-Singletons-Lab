using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    private static AudioController _instance;
    public static AudioController Instance { get { return _instance;}}
    public AudioSource audioSource;
    public AudioClip ballLost, blockLost, bounce;


    public void PlayBallLost(){
        audioSource.PlayOneShot(ballLost);
    }

    public void PlayBlockLost(){
        audioSource.PlayOneShot(blockLost);
    }

    public void PlayBounce(){
        audioSource.PlayOneShot(bounce);
    }

    // Start is called before the first frame update
    void Start()
    {
        _instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
