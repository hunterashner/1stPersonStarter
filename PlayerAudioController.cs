using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAudioController : MonoBehaviour
{
    AudioSource gameAudio;

    bool playSound;
    bool toggle;
    // Start is called before the first frame update
    void Start()
    {
        gameAudio = GetComponent<AudioSource>();
        playSound = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (playSound == true && toggle == true)
        {
            gameAudio.Play();
            toggle = false;
        }

        if (playSound == false && toggle == true)
        {
            gameAudio.Stop();
            toggle = false;
        }
    }
}
