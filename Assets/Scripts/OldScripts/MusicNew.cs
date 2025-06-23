using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;
using FMOD.Studio;

public class MusicNew : MonoBehaviour
{
    EventInstance Music; 
    [SerializeField] EventReference musicEvent;

    void Start()
    {
        Music = RuntimeManager.CreateInstance(musicEvent);
        //Music.start();
        //Debug.Log("myszo krowa");
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            if (!Music.isValid())
            {
                Music = RuntimeManager.CreateInstance(musicEvent);
                Music.start();
            }
            else
            {
                Music.start();
            }
        }
        else if (Input.GetKeyDown(KeyCode.X))
        {
            Music.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
        }

        switch (true)
        {
            case true when Input.GetKeyDown(KeyCode.V):
                Music.setParameterByNameWithLabel("MusicSwitcher", "2");
                break;
            case true when Input.GetKeyDown(KeyCode.B):
                Music.setParameterByNameWithLabel("MusicSwitcher", "3");
                break;
            case true when Input.GetKeyDown(KeyCode.N):
                Music.setParameterByNameWithLabel("MusicSwitcher", "4");
                break;
            case true when Input.GetKeyDown(KeyCode.M):
                Music.setParameterByNameWithLabel("MusicSwitcher", "5");
                break;
            case true when Input.GetKeyDown(KeyCode.C):
                Music.setParameterByNameWithLabel("MusicSwitcher", "1");
                break;
        }
    }
}
