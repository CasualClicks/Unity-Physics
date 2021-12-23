using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonFX : MonoBehaviour
{
    public AudioSource myFX;
    public AudioClip ButtonClick;
    public AudioClip ButtonHover;

    public void hover()
    {
        myFX.PlayOneShot(ButtonHover);
    }

    public void click()
    {
        myFX.PlayOneShot(ButtonClick);
    }
}
